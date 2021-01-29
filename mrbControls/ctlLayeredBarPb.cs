﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace mrbControls
{
    #region BarData sub-class
    public class BarData
    {
        public string FriendlyName { get; set; }
        public bool Enabled { get; set; }
        public float Value { get; set; }

        public Color Color { get; set; }
    }
    #endregion

    public partial class ctlLayeredBarPb : UserControl
    {
        public List<BarData> ListValues;
        private float _MinimumValue;
        private float _MaximumValue = 100;
        private string _Tip = "";
        private string _Group = "";
        // https://stackoverflow.com/a/34299931
        // https://stackoverflow.com/questions/51597919/c-sharp-winform-stop-control-property-setting-to-default-when-it-is-set-to-be-a
        protected override Size DefaultSize => new Size(277, 13);
        public new Color DefaultBackColor => Color.Transparent;
        private List<Color> HighlightColors;

        public ctlLayeredBarPb()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint,
                true);
            ListValues = new List<BarData>();
            HighlightColors = new List<Color>();
            InitializeComponent();
        }

        private void AppendVariable(string name, Color color, bool enabled = true, float value = 0)
        {
            ListValues = (List<BarData>) ListValues.Append(new BarData {FriendlyName = name, Color = color, Enabled = enabled, Value = value});
        }

        public void AssignNames(List<string> names)
        {
            ListValues.Clear();
            foreach (var e in names)
            {
                AppendVariable(e, Color.Magenta);
            }
            SetHighlightColors();
        }

        public void AssignNames(List<(string name, Color color)> listSettings)
        {
            ListValues.Clear();
            foreach (var e in listSettings)
            {
                AppendVariable(e.name, e.color);
            }
            SetHighlightColors();
        }

        public void AssignValues(List<float> values)
        {
            for (var i=0 ; i<values.Count; i++)
            {
                ListValues[i].Value = values[i];
            }
        }

        public void AssignValues(List<(string name, float value)> listValues)
        {
            for (var i = 0; i < listValues.Count; i++)
            {
                var idx = ListValues.FindIndex(e => e.FriendlyName == listValues[i].name);
                ListValues[idx].Value = listValues[i].value;
            }
        }

        public void AssignZero()
        {
            foreach (var e in ListValues)
            {
                e.Value = 0;
            }
        }

        private void SetHighlightColors()
        {
            HighlightColors.Clear();
            for (var i=0; i<ListValues.Count; i++)
            {
                var hlsColor = HLSColor.FromRgb(ListValues[i].Color);
                HighlightColors[i] = HLSColor.ToRgb(hlsColor.H, Math.Min(1, hlsColor.L + 0.2), hlsColor.S);
            }
        }

        #region Properties
        [Description("Minimum bar value"), Category("Data"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float MinimumBarValue
        {
            get => _MinimumValue;
            set => _MinimumValue = value;
        }

        [Description("Maximum bar value"), Category("Data"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float MaximumBarValue
        {
            get => _MaximumValue;
            set => _MaximumValue = value;
        }

        [Description("Bar group"), Category("Data"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Group
        {
            get => _Group;
            set => _Group = value;
        }

        [Description("Tooltip text"), Category("Appearance"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Tip
        {
            get => _Tip;
            set => _Tip = value;
        }
        #endregion

        private int Value2Pixels(float value)
        {
            return (int)Math.Floor(Width / Math.Abs(_MaximumValue - _MinimumValue) * (value - _MinimumValue));
        }

        public void Draw()
        {
            var sortedList = new List<BarData>();
            sortedList.AddRange(ListValues.Where(e => e.Enabled & e.Value > _MinimumValue));
            if (sortedList.Count == 0) return;

            sortedList.Sort((a, b) => -a.Value.CompareTo(b.Value));
            sortedList = (List<BarData>) sortedList.Select(e => new BarData
            {
                FriendlyName = e.FriendlyName,
                Color = e.Color,
                Enabled = e.Enabled,
                Value = Value2Pixels(e.Value)
            });



        }

        #region HLSColor sub-class
        private class HLSColor
        {
            public readonly double H;
            public readonly double L;
            public readonly double S;

            private HLSColor(double h, double l, double s)
            {
                H = h;
                L = l;
                S = s;
            }

            public static HLSColor FromRgb(Color c)
            {
                double h;
                double s;
                double l;

                // Convert RGB to a 0.0 to 1.0 range.
                var doubleR = c.R / 255d;
                var doubleG = c.G / 255d;
                var doubleB = c.B / 255d;

                // Get the maximum and minimum RGB components.
                var max = doubleR;
                if (max < doubleG) max = doubleG;
                if (max < doubleB) max = doubleB;

                var min = doubleR;
                if (min > doubleG) min = doubleG;
                if (min > doubleB) min = doubleB;

                var diff = max - min;
                l = (max + min) / 2;
                if (Math.Abs(diff) < double.Epsilon) //0.00001
                {
                    s = 0;
                    h = 0; // H is really undefined.
                }
                else
                {
                    s = l <= 0.5 ? diff / (max + min) : diff / (2 - max - min);

                    var rDist = (max - doubleR) / diff;
                    var gDist = (max - doubleG) / diff;
                    var bDist = (max - doubleB) / diff;

                    if (Math.Abs(doubleR - max) < double.Epsilon)
                    {
                        h = bDist - gDist;
                    }
                    else if (Math.Abs(doubleG - max) < double.Epsilon)
                    {
                        h = 2 + rDist - bDist;
                    }
                    else
                    {
                        h = 4 + gDist - rDist;
                    }

                    h *= 60;
                    if (h < 0)
                    {
                        h += 360;
                    }
                }

                return new HLSColor(h, l, s);
            }

            public Color ToRgb()
            {
                int r;
                int g;
                int b;

                double p2;
                if (L <= 0.5) p2 = L * (1 + S);
                else p2 = L + S - L * S;

                var p1 = 2 * L - p2;
                double doubleR, doubleG, doubleB;
                if (S == 0)
                {
                    doubleR = L;
                    doubleG = L;
                    doubleB = L;
                }
                else
                {
                    doubleR = QqhToRgb(p1, p2, H + 120);
                    doubleG = QqhToRgb(p1, p2, H);
                    doubleB = QqhToRgb(p1, p2, H - 120);
                }

                // Convert RGB to the 0 to 255 range.
                r = (int)(doubleR * 255.0);
                g = (int)(doubleG * 255.0);
                b = (int)(doubleB * 255.0);

                return Color.FromArgb(r, g, b);
            }

            public static Color ToRgb(double h, double l, double s)
            {
                int r;
                int g;
                int b;

                double p2;
                if (l <= 0.5)
                {
                    p2 = l * (1 + s);
                }
                else
                {
                    p2 = l + s - l * s;
                }

                var p1 = 2 * l - p2;
                double doubleR, doubleG, doubleB;
                if (s == 0)
                {
                    doubleR = l;
                    doubleG = l;
                    doubleB = l;
                }
                else
                {
                    doubleR = QqhToRgb(p1, p2, h + 120);
                    doubleG = QqhToRgb(p1, p2, h);
                    doubleB = QqhToRgb(p1, p2, h - 120);
                }

                // Convert RGB to the 0 to 255 range.
                r = (int)(doubleR * 255.0);
                g = (int)(doubleG * 255.0);
                b = (int)(doubleB * 255.0);

                return Color.FromArgb(r, g, b);
            }

            private static double QqhToRgb(double q1, double q2, double hue)
            {
                if (hue > 360) hue -= 360;
                else if (hue < 0) hue += 360;

                if (hue < 60) return q1 + (q2 - q1) * hue / 60;
                if (hue < 180) return q2;
                if (hue < 240) return q1 + (q2 - q1) * (240 - hue) / 60;
                return q1;
            }
        }
        #endregion
    }
}