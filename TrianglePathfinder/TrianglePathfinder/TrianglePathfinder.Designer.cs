
namespace TrianglePathfinder
{
    partial class TrianglePathfinder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.triangleSizeMasked = new System.Windows.Forms.MaskedTextBox();
            this.makeButton = new System.Windows.Forms.Button();
            this.resultInfoBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxGraph = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // triangleSizeMasked
            // 
            this.triangleSizeMasked.Location = new System.Drawing.Point(175, 9);
            this.triangleSizeMasked.Mask = "00";
            this.triangleSizeMasked.Name = "triangleSizeMasked";
            this.triangleSizeMasked.Size = new System.Drawing.Size(39, 20);
            this.triangleSizeMasked.TabIndex = 8;
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(220, 9);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(116, 20);
            this.makeButton.TabIndex = 9;
            this.makeButton.Text = "Создать";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultInfoBox
            // 
            this.resultInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resultInfoBox.BackColor = System.Drawing.Color.White;
            this.resultInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultInfoBox.Location = new System.Drawing.Point(3, 35);
            this.resultInfoBox.Name = "resultInfoBox";
            this.resultInfoBox.ReadOnly = true;
            this.resultInfoBox.Size = new System.Drawing.Size(333, 479);
            this.resultInfoBox.TabIndex = 10;
            this.resultInfoBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Размер треугольника X на X:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.picBoxGraph);
            this.panel2.Location = new System.Drawing.Point(341, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 502);
            this.panel2.TabIndex = 22;
            // 
            // picBoxGraph
            // 
            this.picBoxGraph.BackColor = System.Drawing.Color.White;
            this.picBoxGraph.Location = new System.Drawing.Point(2, 2);
            this.picBoxGraph.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxGraph.Name = "picBoxGraph";
            this.picBoxGraph.Size = new System.Drawing.Size(843, 494);
            this.picBoxGraph.TabIndex = 5;
            this.picBoxGraph.TabStop = false;
            // 
            // TrianglePathfinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1203, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultInfoBox);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.triangleSizeMasked);
            this.Name = "TrianglePathfinder";
            this.Text = "TrianglePathfinder";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox triangleSizeMasked;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.RichTextBox resultInfoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxGraph;
    }
}

