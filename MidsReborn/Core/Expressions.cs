﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using Jace;
using Mids_Reborn.Core.Base.Master_Classes;

namespace Mids_Reborn.Core
{
    public class Expressions
    {
        public string Duration { get; set; } = "";
        public string Magnitude { get; set; } = "";
        public string Probability { get; set; } = "";

        public struct ErrorData
        {
            public ExpressionType Type { get; set; }
            public bool Found { get; set; }
            public string Message { get; set; }
        }

        public enum ExpressionType
        {
            Duration,
            Magnitude,
            Probability
        }

        public static readonly List<string> CommandsList = new()
        {
            "power.base>activateperiod",
            "power.base>activatetime",
            "power.base>areafactor",
            "power.base>rechargetime",
            "power.base>endcost",
            "power.base>range",
            "effect>scale",
            "@StdResult",
            "ifPvE",
            "ifPvP",
            "modifier>current",
            "maxEndurance",
            "rand()",
            "source.ownPower?(",
            "source>Base.kHitPoints",
            "source>Max.kHitPoints",
            ">variableVal",
            "modifier>",
            "powerGroupIn(",
            "powerGroupNotIn(",
            "powerIs(",
            "powerIsNot(",
            "powerVectorsContains(",
            "source.owner>arch(",
            "eq(",
            "ne(",
            "gt(",
            "gte(",
            "lt(",
            "lte(",
            "minmax(",
        };


        private static Dictionary<string, string> CommandsDict(IEffect sourceFx)
        {
            var fxPower = sourceFx.GetPower();

            return new Dictionary<string, string>
            {
                { "power.base>activateperiod", $"{(fxPower == null ? "0" : fxPower.ActivatePeriod)}"},
                { "power.base>activatetime", $"{(fxPower == null ? "0" : fxPower.CastTime)}" },
                { "power.base>areafactor", $"{(fxPower == null ? "0" : fxPower.AoEModifier)}" },
                { "power.base>rechargetime", $"{(fxPower == null ? "0" : fxPower.BaseRechargeTime)}" },
                { "power.base>endcost", $"{(fxPower == null ? "0" : fxPower.EndCost)}" },
                { "power.base>range", $"{(fxPower == null ? "0" : fxPower.Range)}" },
                { "effect>scale", $"{sourceFx.Scale}" },
                { "@StdResult", $"{sourceFx.Scale}" },
                { "ifPvE", sourceFx.PvMode == Enums.ePvX.PvE ? "1" : "0" },
                { "ifPvP", sourceFx.PvMode == Enums.ePvX.PvP ? "1" : "0" },
                { "modifier>current", $"{DatabaseAPI.GetModifier(sourceFx)}" },
                { "maxEndurance", $"{MidsContext.Character.DisplayStats.EnduranceMaxEnd}" },
                { "rand()", $"{sourceFx.Rand}" },
                { "cur.kToHit", $"{MidsContext.Character.DisplayStats.BuffToHit}"},
                { "base.kToHit", $"{(MidsContext.Config == null ? 0 : MidsContext.Config.ScalingToHit)}"},
                { "source>Max.kHitPoints", $"{MidsContext.Character.Totals.HPMax}" },
                { "source>Base.kHitPoints", $"{(MidsContext.Character.Archetype == null ? 1000 : MidsContext.Character.Archetype.Hitpoints)}"}
            };
        }

        private static Dictionary<Regex, MatchEvaluator> FunctionsDict(IEffect sourceFx, List<string?> pickedPowerNames)
        {
            var fxPower = sourceFx.GetPower();

            return new Dictionary<Regex, MatchEvaluator>
            {
                { new Regex(@"source\.ownPower\?\(([a-zA-Z0-9_\-\.]+)\)"), e => pickedPowerNames.Contains(e.Groups[1].Value) ? "1" : "0" },
                { new Regex(@"([a-zA-Z\-_\.]+)>variableVal"), e => GetVariableValue(e.Groups[1].Value) },
                { new Regex(@"modifier\>([a-zA-Z0-9_\-]+)"), e => GetModifier(e.Groups[1].Value) },
                { new Regex(@"powerGroupIn\(([a-zA-Z0-9_\-\.]+)\)"), e => fxPower == null ? "0" : fxPower.FullName.StartsWith(e.Groups[1].Value) ? "1" : "0" },
                { new Regex(@"powerGroupNotIn\(([a-zA-Z0-9_\-\.]+)\)"), e => fxPower == null ? "0" : fxPower.FullName.StartsWith(e.Groups[1].Value) ? "0" : "1" },
                { new Regex(@"powerIs\(([a-zA-Z0-9_\-\.]+)\)"), e => fxPower == null ? "0" : fxPower.FullName.Equals(e.Groups[1].Value, StringComparison.InvariantCultureIgnoreCase) ? "1" : "0" },
                { new Regex(@"powerIsNot\(([a-zA-Z0-9_\-\.]+)\)"), e => fxPower == null ? "0" : fxPower.FullName.Equals(e.Groups[1].Value, StringComparison.InvariantCultureIgnoreCase) ? "0" : "1" },
                { new Regex(@"powerVectorsContains\(([a-zA-Z0-9_\-\.]+)\)"), e => PowerVectorsContains(sourceFx.GetPower(), e.Groups[1].Value) },
                { new Regex(@"source\.owner\>arch\(([a-zA-Z\s]+)\)"), e => MidsContext.Character.Archetype == null ? "0" : MidsContext.Character.Archetype.DisplayName.Equals(e.Groups[1].Value, StringComparison.InvariantCultureIgnoreCase) ? "1" : "0"}
            };
        }

        private static string PowerVectorsContains(IPower? sourcePower, string vector)
        {
            var ret = Enum.TryParse(typeof(Enums.eVector), vector, out var eValue);

            if (!ret)
            {
                return "0";
            }

            return (sourcePower.AttackTypes & (Enums.eVector) eValue) == Enums.eVector.None ? "0" : "1";
        }

        private static string GetModifier(string modifierName)
        {
            var modTable = DatabaseAPI.Database.AttribMods.Modifier.Where(e => e.ID == modifierName).ToList();

            return modTable.Count <= 0
                ? "0"
                : $"{Math.Abs(modTable[0].Table[MidsContext.Character.Level][MidsContext.Character.Archetype.Column])}";
        }

        private static string GetVariableValue(string powerName)
        {
            var target = MidsContext.Character.CurrentBuild.Powers.FirstOrDefault(x => x.Power != null && x.Power.FullName == powerName);
            return target == null ? "0" : $"{target.VariableValue}";
        }

        public static float Parse(IEffect sourceFx, ExpressionType expressionType, out ErrorData error)
        {
            error = new ErrorData();
            float retValue;
            switch (expressionType)
            {
                case ExpressionType.Duration:
                    retValue = InternalParsing(sourceFx, expressionType, out error);
                    break;

                case ExpressionType.Probability:
                    retValue = InternalParsing(sourceFx, expressionType, out error);
                    break;

                case ExpressionType.Magnitude:
                    if (sourceFx.Expressions.Magnitude.IndexOf(".8 rechargetime power.base> 1 30 minmax * 1.8 + 2 * @StdResult * 10 / areafactor power.base> /", StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        retValue = (float)((Math.Max(Math.Min(sourceFx.GetPower().RechargeTime, 30f), 0.0f) * 0.800000011920929 + 1.79999995231628) / 5.0) / sourceFx.GetPower().AoEModifier * sourceFx.Scale;
                        if (sourceFx.Expressions.Magnitude.Length > ".8 rechargetime power.base> 1 30 minmax * 1.8 + 2 * @StdResult * 10 / areafactor power.base> /".Length + 2)
                        {
                            retValue *= float.Parse(sourceFx.Expressions.Magnitude.Substring(".8 rechargetime power.base> 1 30 minmax * 1.8 + 2 * @StdResult * 10 / areafactor power.base> /".Length + 1).Substring(0, 2));
                        }

                        return retValue;
                    }

                    if (string.IsNullOrWhiteSpace(sourceFx.Expressions.Magnitude)) return 0f;

                    var baseFx = sourceFx.Clone() as IEffect;
                    retValue = InternalParsing(baseFx, expressionType, out error);

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(expressionType), expressionType, null);
            }

            return error.Found ? 0f : retValue;
        }

        private static float InternalParsing(IEffect sourceFx, ExpressionType expressionType, out ErrorData error)
        {
            var pickedPowerNames = MidsContext.Character.CurrentBuild == null ? new List<string?>() : MidsContext.Character.CurrentBuild.Powers.Select(pe => pe?.Power?.FullName).ToList();

            error = new ErrorData();
            var mathEngine = CalculationEngine.New<double>();
            var expr = expressionType switch
            {
                ExpressionType.Duration => sourceFx.Expressions.Duration,
                ExpressionType.Magnitude => sourceFx.Expressions.Magnitude,
                ExpressionType.Probability => sourceFx.Expressions.Probability,
                _ => throw new ArgumentOutOfRangeException(nameof(expressionType), expressionType, null)
            };

            // Constants
            expr = CommandsDict(sourceFx).Aggregate(expr, (current, cmd) => current.Replace(cmd.Key, cmd.Value));

            // Non-numeric functions
            expr = FunctionsDict(sourceFx, pickedPowerNames).Aggregate(expr, (current, f1) => f1.Key.Replace(current, f1.Value));

            // Numeric functions
            mathEngine.AddFunction("eq", (a, b) => Math.Abs(a - b) < double.Epsilon ? 1 : 0);
            mathEngine.AddFunction("ne", (a, b) => Math.Abs(a - b) > double.Epsilon ? 1 : 0);
            mathEngine.AddFunction("gt", (a, b) => a > b ? 1 : 0);
            mathEngine.AddFunction("gte", (a, b) => a >= b ? 1 : 0);
            mathEngine.AddFunction("lt", (a, b) => a < b ? 1 : 0);
            mathEngine.AddFunction("lte", (a, b) => a <= b ? 1 : 0);
            mathEngine.AddFunction("minmax", (a, b, c) => Math.Min(b > c ? b : c, Math.Max(b > c ? c : b, a)));

            try
            {
                return (float)mathEngine.Calculate(expr);
            }
            catch (ParseException ex)
            {
                Debug.WriteLine($"Expression failed in {expr}\n  Power: {sourceFx.GetPower()?.FullName}");

                error.Type = expressionType;
                error.Found = true;
                error.Message = ex.Message;

                return 0;
            }
            catch (VariableNotDefinedException ex)
            {
                Debug.WriteLine($"Expression failed (variable not defined) in {expr}\nPower: {sourceFx.GetPower()?.FullName}");

                error.Type = expressionType;
                error.Found = true;
                error.Message = ex.Message;

                return 0;
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine($"Expression failed (invalid operation) in {expr}\nPower: {sourceFx.GetPower()?.FullName}");

                error.Type = expressionType;
                error.Found = true;
                error.Message = ex.Message;

                return 0;
            }
        }

        public struct Validation
        {
            public ExpressionType Type { get; set; }
            public bool Validated { get; set; }
            public string Message { get; set; }
        }

        public static void Validate(IEffect fx, out List<Validation> validationItems)
        {
            ErrorData error;
            ExpressionType type;
            validationItems = new List<Validation>();

            if (!string.IsNullOrWhiteSpace(fx.Expressions.Duration))
            {
                type = ExpressionType.Duration;
                Parse(fx, type, out error);
                if (error.Found)
                {
                    validationItems.Add(new Validation
                    {
                        Type = error.Type,
                        Validated = false,
                        Message = $"{type} Expression Error: {error.Message}"
                    });
                }
                else
                {
                    validationItems.Add(new Validation
                    {
                        Type = type,
                        Validated = true
                    });
                }
            }

            if (!string.IsNullOrWhiteSpace(fx.Expressions.Magnitude))
            {
                type = ExpressionType.Magnitude;
                Parse(fx, type, out error);
                if (error.Found)
                {
                    validationItems.Add(new Validation
                    {
                        Type = error.Type,
                        Validated = false,
                        Message = $"{type} Expression Error: {error.Message}"
                    });
                }
                else
                {
                    validationItems.Add(new Validation
                    {
                        Type = type,
                        Validated = true
                    });
                }
            }

            if (!string.IsNullOrWhiteSpace(fx.Expressions.Probability))
            {
                type = ExpressionType.Probability;
                Parse(fx, type, out error);
                if (error.Found)
                {
                    validationItems.Add(new Validation
                    {
                        Type = error.Type,
                        Validated = false,
                        Message = $"{type} Expression Error: {error.Message}"
                    });
                }
                else
                {
                    validationItems.Add(new Validation
                    {
                        Type = type,
                        Validated = true
                    });
                }
            }
        }
    }
}