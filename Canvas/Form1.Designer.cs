namespace Canvas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 100);
            this.panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            this.color_picker.Image = global::Canvas.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(2, 2);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(222, 97);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 10;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_line
            // 
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::Canvas.Properties.Resources.line;
            this.btn_line.Location = new System.Drawing.Point(695, 26);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(57, 53);
            this.btn_line.TabIndex = 8;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::Canvas.Properties.Resources.circle;
            this.btn_ellipse.Location = new System.Drawing.Point(569, 26);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(57, 53);
            this.btn_ellipse.TabIndex = 6;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::Canvas.Properties.Resources.eraser;
            this.btn_eraser.Location = new System.Drawing.Point(506, 26);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(57, 53);
            this.btn_eraser.TabIndex = 5;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::Canvas.Properties.Resources.pencil;
            this.btn_pencil.Location = new System.Drawing.Point(442, 26);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(58, 53);
            this.btn_pencil.TabIndex = 4;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_fill.Image")));
            this.btn_fill.Location = new System.Drawing.Point(381, 26);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(55, 53);
            this.btn_fill.TabIndex = 3;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_color
            // 
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::Canvas.Properties.Resources.color;
            this.btn_color.Location = new System.Drawing.Point(313, 26);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(62, 53);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Cursor = System.Windows.Forms.Cursors.Help;
            this.pic_color.Location = new System.Drawing.Point(237, 27);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(56, 52);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Location = new System.Drawing.Point(299, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 77);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_save.Location = new System.Drawing.Point(459, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(57, 24);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Location = new System.Drawing.Point(459, 43);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(57, 24);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.Gray;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::Canvas.Properties.Resources.rectangle;
            this.btn_rect.Location = new System.Drawing.Point(333, 14);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(57, 53);
            this.btn_rect.TabIndex = 0;
            this.btn_rect.Text = "Rect";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 25);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(856, 429);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_color;
        private Button pic_color;
        private Panel panel2;
        private PictureBox pic;
        private Button btn_pencil;
        private Button btn_fill;
        private Button btn_eraser;
        private Button btn_ellipse;
        private Panel panel3;
        private Button btn_line;
        private PictureBox color_picker;
        private Button btn_rect;
        private Button btn_clear;
        private Button btn_save;
    }
}