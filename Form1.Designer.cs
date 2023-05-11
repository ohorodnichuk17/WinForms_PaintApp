namespace WinFormsPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fillBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.colorBtn = new System.Windows.Forms.Button();
            this.rectBtn = new System.Windows.Forms.Button();
            this.pencilBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.eraserBtn = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 125);
            this.panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearBtn.Location = new System.Drawing.Point(950, 65);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 31);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::WinFormsPaint.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(0, 0);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(335, 125);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 10;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(341, 50);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(54, 50);
            this.pic_color.TabIndex = 3;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.fillBtn);
            this.panel3.Controls.Add(this.lineBtn);
            this.panel3.Controls.Add(this.colorBtn);
            this.panel3.Controls.Add(this.rectBtn);
            this.panel3.Controls.Add(this.pencilBtn);
            this.panel3.Controls.Add(this.ellipseBtn);
            this.panel3.Controls.Add(this.eraserBtn);
            this.panel3.Location = new System.Drawing.Point(401, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 101);
            this.panel3.TabIndex = 3;
            // 
            // fillBtn
            // 
            this.fillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fillBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.fillBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillBtn.ForeColor = System.Drawing.Color.White;
            this.fillBtn.Image = global::WinFormsPaint.Properties.Resources.bucket;
            this.fillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fillBtn.Location = new System.Drawing.Point(92, 24);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(65, 60);
            this.fillBtn.TabIndex = 5;
            this.fillBtn.Text = "Fill";
            this.fillBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.lineBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.ForeColor = System.Drawing.Color.White;
            this.lineBtn.Image = global::WinFormsPaint.Properties.Resources.line;
            this.lineBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lineBtn.Location = new System.Drawing.Point(305, 24);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(65, 60);
            this.lineBtn.TabIndex = 5;
            this.lineBtn.Text = "Line";
            this.lineBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.colorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBtn.ForeColor = System.Drawing.Color.White;
            this.colorBtn.Image = global::WinFormsPaint.Properties.Resources.color;
            this.colorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorBtn.Location = new System.Drawing.Point(21, 24);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(65, 60);
            this.colorBtn.TabIndex = 4;
            this.colorBtn.Text = "Color";
            this.colorBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.rectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectBtn.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rectBtn.ForeColor = System.Drawing.Color.White;
            this.rectBtn.Image = global::WinFormsPaint.Properties.Resources.rectangle;
            this.rectBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectBtn.Location = new System.Drawing.Point(447, 24);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(71, 60);
            this.rectBtn.TabIndex = 9;
            this.rectBtn.Text = "Rectangle";
            this.rectBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectBtn.UseVisualStyleBackColor = true;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // pencilBtn
            // 
            this.pencilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencilBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.pencilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilBtn.ForeColor = System.Drawing.Color.White;
            this.pencilBtn.Image = global::WinFormsPaint.Properties.Resources.pencil;
            this.pencilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pencilBtn.Location = new System.Drawing.Point(163, 24);
            this.pencilBtn.Name = "pencilBtn";
            this.pencilBtn.Size = new System.Drawing.Size(65, 60);
            this.pencilBtn.TabIndex = 6;
            this.pencilBtn.Text = "Pencil";
            this.pencilBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencilBtn.UseVisualStyleBackColor = true;
            this.pencilBtn.Click += new System.EventHandler(this.pencilBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.ellipseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ellipseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseBtn.ForeColor = System.Drawing.Color.White;
            this.ellipseBtn.Image = global::WinFormsPaint.Properties.Resources.circle;
            this.ellipseBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ellipseBtn.Location = new System.Drawing.Point(376, 24);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(65, 60);
            this.ellipseBtn.TabIndex = 8;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // eraserBtn
            // 
            this.eraserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.eraserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eraserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserBtn.ForeColor = System.Drawing.Color.White;
            this.eraserBtn.Image = global::WinFormsPaint.Properties.Resources.eraser;
            this.eraserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eraserBtn.Location = new System.Drawing.Point(234, 24);
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(65, 60);
            this.eraserBtn.TabIndex = 7;
            this.eraserBtn.Text = "Eraser";
            this.eraserBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eraserBtn.UseVisualStyleBackColor = true;
            this.eraserBtn.Click += new System.EventHandler(this.eraserBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 36);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1037, 503);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1037, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button rectBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button eraserBtn;
        private System.Windows.Forms.Button pencilBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button clearBtn;
    }
}
