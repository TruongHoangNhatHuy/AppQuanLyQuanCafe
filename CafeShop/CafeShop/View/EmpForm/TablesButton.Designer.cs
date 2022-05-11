namespace CafeShop.EmpForm
{
    partial class TablesButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableButton = new CafeShop.CustomControl.JButton();
            this.SuspendLayout();
            // 
            // TableButton
            // 
            this.TableButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TableButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.TableButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.TableButton.BorderRadius = 30;
            this.TableButton.BorderSize = 0;
            this.TableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableButton.FlatAppearance.BorderSize = 0;
            this.TableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButton.ForeColor = System.Drawing.Color.White;
            this.TableButton.Image = global::CafeShop.Properties.Resources.round_table;
            this.TableButton.Location = new System.Drawing.Point(0, 0);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(55, 49);
            this.TableButton.TabIndex = 0;
            this.TableButton.Text = "1";
            this.TableButton.TextColor = System.Drawing.Color.White;
            this.TableButton.UseVisualStyleBackColor = false;
            // 
            // TablesButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableButton);
            this.Name = "TablesButton";
            this.Size = new System.Drawing.Size(55, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.JButton TableButton;
        
    }
}
