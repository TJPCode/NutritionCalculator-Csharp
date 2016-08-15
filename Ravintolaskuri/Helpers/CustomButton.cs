using System;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomButton
{
    #region THEME
    #region ENUM

    public enum Theme
    {
        BUTTON_GRAY = 1,
    }
    #endregion

    #region COLOR TABLE
    [TypeConverter(typeof(ExpandableObjectConverter))]

    public class Colortable
    {
        #region Static Color Tables
        static GrayButton grayBtn = new GrayButton();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010White
        {
            get { return grayBtn; }
        }     
        #endregion

        #region Custom Properties
        Color textColor = Color.White;
        Color selectedTextColor = Color.FromArgb(30, 57, 91);
        Color OverTextColor = Color.FromArgb(30, 57, 91);
        Color borderColor = Color.FromArgb(31, 72, 161);
        Color innerborderColor = Color.FromArgb(68, 135, 228);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color SelectedTextColor
        {
            get { return selectedTextColor; }
            set { selectedTextColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color HoverTextColor
        {
            get { return OverTextColor; }
            set { OverTextColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color BorderColor1
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color BorderColor2
        {
            get { return innerborderColor; }
            set { innerborderColor = value; }
        }
        #endregion

        #region Button Normal
        Color buttonNormalBegin = Color.FromArgb(31, 72, 161);
        Color buttonNormalMiddleBegin = Color.FromArgb(68, 135, 228);
        Color buttonNormalMiddleEnd = Color.FromArgb(41, 97, 181);
        Color buttonNormalEnd = Color.FromArgb(62, 125, 219);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor1
        {
            get { return buttonNormalBegin; }
            set { buttonNormalBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor2
        {
            get { return buttonNormalMiddleBegin; }
            set { buttonNormalMiddleBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor3
        {
            get { return buttonNormalMiddleEnd; }
            set { buttonNormalMiddleEnd = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor4
        {
            get { return buttonNormalEnd; }
            set { buttonNormalEnd = value; }
        }
        #endregion

        #region Button Selected
        Color buttonSelectedBegin = Color.FromArgb(236, 199, 87);

        Color buttonSelectedMiddleBegin = Color.FromArgb(252, 243, 215);

        Color buttonSelectedMiddleEnd = Color.FromArgb(255, 229, 117);

        Color buttonSelectedEnd = Color.FromArgb(255, 216, 107);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonSelectedColor1
        {

            get { return buttonSelectedBegin; }

            set { buttonSelectedBegin = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonSelectedColor2
        {

            get { return buttonSelectedMiddleBegin; }

            set { buttonSelectedMiddleBegin = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonSelectedColor3
        {

            get { return buttonSelectedMiddleEnd; }

            set { buttonSelectedMiddleEnd = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonSelectedColor4
        {

            get { return buttonSelectedEnd; }

            set { buttonSelectedEnd = value; }

        }

        #endregion

        #region Button Mouse Over

        Color buttonMouseOverBegin = Color.FromArgb(236, 199, 87);

        Color buttonMouseOverMiddleBegin = Color.FromArgb(252, 243, 215);

        Color buttonMouseOverMiddleEnd = Color.FromArgb(249, 225, 137);

        Color buttonMouseOverEnd = Color.FromArgb(251, 249, 224);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonMouseOverColor1
        {

            get { return buttonMouseOverBegin; }

            set { buttonMouseOverBegin = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonMouseOverColor2
        {

            get { return buttonMouseOverMiddleBegin; }

            set { buttonMouseOverMiddleBegin = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonMouseOverColor3
        {

            get { return buttonMouseOverMiddleEnd; }

            set { buttonMouseOverMiddleEnd = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public virtual Color ButtonMouseOverColor4
        {

            get { return buttonMouseOverEnd; }

            set { buttonMouseOverEnd = value; }

        }

        #endregion
    }
    #endregion

    #region Gray button
    public class GrayButton : Colortable
    {
        public GrayButton()
        {
            // Border Color
            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color
            this.TextColor = Color.White;
            this.SelectedTextColor = Color.Black;
            this.HoverTextColor = Color.Black;

            // Button normal color
            this.ButtonNormalColor1 = Color.Black;
            this.ButtonNormalColor2 = Color.DimGray;
            this.ButtonNormalColor3 = Color.FromArgb(64, 64, 64);
            this.ButtonNormalColor4 = Color.Silver;

            // Button mouseover color
            this.ButtonMouseOverColor1 = Color.Black;
            this.ButtonMouseOverColor2 = Color.Silver;
            this.ButtonMouseOverColor3 = Color.DimGray;
            this.ButtonMouseOverColor4 = Color.White;

            // Button selected color

            this.ButtonSelectedColor1 = Color.Black;
            this.ButtonSelectedColor2 = Color.White;
            this.ButtonSelectedColor3 = Color.Silver;
            this.ButtonSelectedColor4 = Color.Silver;
        }

        public override string ToString()
        {
            return "Office2010White";
        }
    }
    #endregion

    #endregion

    #region Button

    public partial class XButton1 : Button
    {
        #region Fields
        private CustomButton.Theme thm = CustomButton.Theme.BUTTON_GRAY;
        private enum MouseState { None = 1, Down = 2, Up = 3, Enter = 4, Leave = 5, Move = 6 }
        private MouseState MState = MouseState.None;
        #endregion

        #region Constructor
        public XButton1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                      ControlStyles.Opaque |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.CacheText, // We gain about 2% in painting by avoiding extra GetWindowText calls

                      true);
            this.colorTable = new Colortable();
            this.MouseLeave += new EventHandler(_MouseLeave);
            this.MouseDown += new MouseEventHandler(_MouseDown);
            this.MouseUp += new MouseEventHandler(_MouseUp);
            this.MouseMove += new MouseEventHandler(_MouseMove);
        }
        #endregion

        #region Events

        #region Paint Transparent Background
        protected void PaintTransparentBackground(Graphics g, Rectangle clipRect)
        {
            // check if we have a parent
            if (this.Parent != null)
            {
                // convert the clipRects coordinates from ours to our parents
                clipRect.Offset(this.Location);
                PaintEventArgs e = new PaintEventArgs(g, clipRect);

                // save the graphics state so that if anything goes wrong 

                // we're not fubar

                GraphicsState state = g.Save();

                try
                {
                    // move the graphics object so that we are drawing in 
                    // the correct place
                    g.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);
                    // draw the parents background and foreground
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);
                    return;
                }
                finally
                {
                    // reset everything back to where they were before
                    g.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }
            // we don't have a parent, so fill the rect with
            // the default control color
            g.FillRectangle(SystemBrushes.Control, clipRect);
        }
        #endregion

        #region Mouse Events
        private void _MouseDown(object sender, MouseEventArgs mevent)
        {
            MState = MouseState.Down;
            Invalidate();
        }

        private void _MouseUp(object sender, MouseEventArgs mevent)
        {
            MState = MouseState.Up;
            Invalidate();
        }

        private void _MouseMove(object sender, MouseEventArgs mevent)
        {
            MState = MouseState.Move;
            Invalidate();
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            MState = MouseState.Leave;
            Invalidate();
        }
        #endregion

        #region Path
        public static GraphicsPath GetRoundedRect(RectangleF r, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            r = new RectangleF(r.Left, r.Top, r.Width, r.Height);

            if (radius <= 0.0F || radius <= 0.0F)
            {
                gp.AddRectangle(r);
            }

            else
            {
                gp.AddArc((float)r.X, (float)r.Y, radius, radius, 180, 90);
                gp.AddArc((float)r.Right - radius, (float)r.Y, radius - 1, radius, 270, 90);
                gp.AddArc((float)r.Right - radius, ((float)r.Bottom) - radius - 1, radius - 1, radius, 0, 90);
                gp.AddArc((float)r.X, ((float)r.Bottom) - radius - 1, radius - 1, radius, 90, 90);
            }

            gp.CloseFigure();
            return gp;
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            this.PaintTransparentBackground(e.Graphics, this.ClientRectangle);

            #region Painting

            //now let's we begin painting

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            #endregion

            #region Color
            Color tTopColorBegin = this.colorTable.ButtonNormalColor1;
            Color tTopColorEnd = this.colorTable.ButtonNormalColor2;
            Color tBottomColorBegin = this.colorTable.ButtonNormalColor3;
            Color tBottomColorEnd = this.colorTable.ButtonNormalColor4;
            Color Textcol = this.colorTable.TextColor;

            if (!this.Enabled)
            {
                tTopColorBegin = Color.FromArgb((int)(tTopColorBegin.GetBrightness() * 255),
                    (int)(tTopColorBegin.GetBrightness() * 255),
                    (int)(tTopColorBegin.GetBrightness() * 255));
                tBottomColorEnd = Color.FromArgb((int)(tBottomColorEnd.GetBrightness() * 255),
                    (int)(tBottomColorEnd.GetBrightness() * 255),
                    (int)(tBottomColorEnd.GetBrightness() * 255));
            }

            else
            {
                if (MState == MouseState.None || MState == MouseState.Leave)
                {
                    tTopColorBegin = this.colorTable.ButtonNormalColor1;
                    tTopColorEnd = this.colorTable.ButtonNormalColor2;
                    tBottomColorBegin = this.colorTable.ButtonNormalColor3;
                    tBottomColorEnd = this.colorTable.ButtonNormalColor4;
                    Textcol = this.colorTable.TextColor;
                }

                else if (MState == MouseState.Down)
                {
                    tTopColorBegin = this.colorTable.ButtonSelectedColor1;
                    tTopColorEnd = this.colorTable.ButtonSelectedColor2;
                    tBottomColorBegin = this.colorTable.ButtonSelectedColor3;
                    tBottomColorEnd = this.colorTable.ButtonSelectedColor4;
                    Textcol = this.colorTable.SelectedTextColor;
                }

                else if (MState == MouseState.Move || MState == MouseState.Up)
                {
                    tTopColorBegin = this.colorTable.ButtonMouseOverColor1;
                    tTopColorEnd = this.colorTable.ButtonMouseOverColor2;
                    tBottomColorBegin = this.colorTable.ButtonMouseOverColor3;
                    tBottomColorEnd = this.colorTable.ButtonMouseOverColor4;
                    Textcol = this.colorTable.HoverTextColor;
                }
            }

            #endregion

            #region Theme 2010
            if (thm == CustomButton.Theme.BUTTON_GRAY)
            {
                Paint2010Background(e, g, tTopColorBegin, tTopColorEnd, tBottomColorBegin, tBottomColorEnd);
                TEXTandIMAGE(this.ClientRectangle, g, Textcol);
            }
            #endregion
        }

        #region Paint 2010 Background
        protected void Paint2010Background(PaintEventArgs e, Graphics g, Color tTopColorBegin, Color tTopColorEnd, Color tBottomColorBegin, Color tBottomColorEnd)
        {
            int _roundedRadiusX = 6;
            Rectangle r = new Rectangle(this.ClientRectangle.Left, this.ClientRectangle.Top, this.ClientRectangle.Width, this.ClientRectangle.Height);
            Rectangle j = r;
            Rectangle r2 = r;
            r2.Inflate(-1, -1);
            Rectangle r3 = r2;
            r3.Inflate(-1, -1);

            //rectangle for gradient, half upper and lower
            RectangleF halfup = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            RectangleF halfdown = new RectangleF(r.Left, r.Top + (r.Height / 2) - 1, r.Width, r.Height);

            //BEGIN PAINT BACKGROUND
            //for half upper, we paint using linear gradient

            using (GraphicsPath thePath = GetRoundedRect(r, _roundedRadiusX))
            {
                LinearGradientBrush lgb = new LinearGradientBrush(halfup, tBottomColorEnd, tBottomColorBegin, 90f, true);
                Blend blend = new Blend(4);
                blend.Positions = new float[] { 0, 0.18f, 0.35f, 1f };
                blend.Factors = new float[] { 0f, .4f, .9f, 1f };
                lgb.Blend = blend;
                g.FillPath(lgb, thePath);
                lgb.Dispose();

                //for half lower, we paint using radial gradient

                using (GraphicsPath p = new GraphicsPath())
                {
                    p.AddEllipse(halfdown); //make it radial

                    using (PathGradientBrush gradient = new PathGradientBrush(p))
                    {
                        gradient.WrapMode = WrapMode.Clamp;
                        gradient.CenterPoint = new PointF(Convert.ToSingle(halfdown.Left + halfdown.Width / 2), Convert.ToSingle(halfdown.Bottom));
                        gradient.CenterColor = tBottomColorEnd;
                        gradient.SurroundColors = new Color[] { tBottomColorBegin };
                        blend = new Blend(4);
                        blend.Positions = new float[] { 0, 0.15f, 0.4f, 1f };
                        blend.Factors = new float[] { 0f, .3f, 1f, 1f };
                        gradient.Blend = blend;
                        g.FillPath(gradient, thePath);
                    }
                }

                //END PAINT BACKGROUND

                //BEGIN PAINT BORDERS

                using (GraphicsPath gborderDark = thePath)
                {
                    using (Pen p = new Pen(tTopColorBegin, 1))
                    {
                        g.DrawPath(p, gborderDark);
                    }
                }

                using (GraphicsPath gborderLight = GetRoundedRect(r2, _roundedRadiusX))
                {
                    using (Pen p = new Pen(tTopColorEnd, 1))
                    {
                        g.DrawPath(p, gborderLight);
                    }
                }

                using (GraphicsPath gborderMed = GetRoundedRect(r3, _roundedRadiusX))
                {
                    SolidBrush bordermed = new SolidBrush(Color.FromArgb(50, tTopColorEnd));

                    using (Pen p = new Pen(bordermed, 1))
                    {
                        g.DrawPath(p, gborderMed);
                    }
                }
                //END PAINT BORDERS
            }
        }
        #endregion

        #region Paint TEXT AND IMAGE
        protected void TEXTandIMAGE(Rectangle Rec, Graphics g, Color textColor)
        {
            //BEGIN PAINT TEXT
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            #region Top
            if (this.TextAlign == ContentAlignment.TopLeft)
            {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Near;
            }

            else if (this.TextAlign == ContentAlignment.TopCenter)
            {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Center;
            }

            else if (this.TextAlign == ContentAlignment.TopRight)
            {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Far;
            }
            #endregion

            #region Middle
            else if (this.TextAlign == ContentAlignment.MiddleLeft)
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Near;
            }

            else if (this.TextAlign == ContentAlignment.MiddleCenter)
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
            }

            else if (this.TextAlign == ContentAlignment.MiddleRight)
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Far;
            }
            #endregion

            #region Bottom
            else if (this.TextAlign == ContentAlignment.BottomLeft)
            {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Near;
            }

            else if (this.TextAlign == ContentAlignment.BottomCenter)
            {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Center;
            }

            else if (this.TextAlign == ContentAlignment.BottomRight)
            {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Far;
            }
            #endregion

            if (this.ShowKeyboardCues)
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
            else
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Hide;
            g.DrawString(this.Text, this.Font, new SolidBrush(textColor), Rec, sf);
        }
        #endregion

        #endregion

        #region Properties

        #region ColorTable
        Colortable colorTable = null;

        [DefaultValue(typeof(Colortable), "Office2010White")]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Colortable ColorTable
        {
            get
            {
                if (colorTable == null)
                    colorTable = new Colortable();

                return colorTable;
            }
            set
            {
                if (value == null)
                    value = Colortable.Office2010White;

                colorTable = (Colortable)value;
                this.Invalidate();
            }
        }

        public CustomButton.Theme Theme
        {
            get
            {
                return CustomButton.Theme.BUTTON_GRAY;
            }
            set
            {
                this.colorTable = Colortable.Office2010White;
            }
        }
        #endregion

        #region Background Image
        [Browsable(false)]

        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }

            set
            {
                base.BackgroundImage = value;
            }
        }

        [Browsable(false)]

        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }

            set
            {
                base.BackgroundImageLayout = value;
            }
        }
        #endregion

        #endregion
    }
    #endregion
}