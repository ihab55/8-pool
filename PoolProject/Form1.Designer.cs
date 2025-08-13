namespace PoolProject
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrPoolTable1 = new PoolProject.ctrPoolTable();
            this.ctrPoolTable2 = new PoolProject.ctrPoolTable();
            this.ctrPoolTable3 = new PoolProject.ctrPoolTable();
            this.ctrPoolTable4 = new PoolProject.ctrPoolTable();
            this.ctrPoolTable5 = new PoolProject.ctrPoolTable();
            this.ctrPoolTable6 = new PoolProject.ctrPoolTable();
            this.SuspendLayout();
            // 
            // ctrPoolTable1
            // 
            this.ctrPoolTable1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrPoolTable1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrPoolTable1.HourlyRate = 10F;
            this.ctrPoolTable1.Location = new System.Drawing.Point(-3, 2);
            this.ctrPoolTable1.Name = "ctrPoolTable1";
            this.ctrPoolTable1.PlayerName = "Player 1";
            this.ctrPoolTable1.Size = new System.Drawing.Size(509, 333);
            this.ctrPoolTable1.TabIndex = 0;
            this.ctrPoolTable1.TableName = "Tabel 1";
            this.ctrPoolTable1.EndTable += new System.EventHandler<PoolProject.ctrPoolTable.CompletedEventArgs>(this.ctrPoolTable1_EndTable);
            // 
            // ctrPoolTable2
            // 
            this.ctrPoolTable2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrPoolTable2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrPoolTable2.HourlyRate = 10F;
            this.ctrPoolTable2.Location = new System.Drawing.Point(502, 2);
            this.ctrPoolTable2.Name = "ctrPoolTable2";
            this.ctrPoolTable2.PlayerName = "Player 2";
            this.ctrPoolTable2.Size = new System.Drawing.Size(509, 333);
            this.ctrPoolTable2.TabIndex = 1;
            this.ctrPoolTable2.TableName = "Tabel 2";
            this.ctrPoolTable2.EndTable += new System.EventHandler<PoolProject.ctrPoolTable.CompletedEventArgs>(this.ctrPoolTable1_EndTable);
            // 
            // ctrPoolTable3
            // 
            this.ctrPoolTable3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrPoolTable3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrPoolTable3.HourlyRate = 10F;
            this.ctrPoolTable3.Location = new System.Drawing.Point(1010, 2);
            this.ctrPoolTable3.Name = "ctrPoolTable3";
            this.ctrPoolTable3.PlayerName = "Player 3";
            this.ctrPoolTable3.Size = new System.Drawing.Size(512, 333);
            this.ctrPoolTable3.TabIndex = 2;
            this.ctrPoolTable3.TableName = "Tabel 3";
            this.ctrPoolTable3.EndTable += new System.EventHandler<PoolProject.ctrPoolTable.CompletedEventArgs>(this.ctrPoolTable1_EndTable);
            // 
            // ctrPoolTable4
            // 
            this.ctrPoolTable4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrPoolTable4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrPoolTable4.HourlyRate = 10F;
            this.ctrPoolTable4.Location = new System.Drawing.Point(1010, 331);
            this.ctrPoolTable4.Name = "ctrPoolTable4";
            this.ctrPoolTable4.PlayerName = "Player";
            this.ctrPoolTable4.Size = new System.Drawing.Size(512, 333);
            this.ctrPoolTable4.TabIndex = 5;
            this.ctrPoolTable4.TableName = "Tabel 1";
            this.ctrPoolTable4.EndTable += new System.EventHandler<PoolProject.ctrPoolTable.CompletedEventArgs>(this.ctrPoolTable1_EndTable);
            // 
            // ctrPoolTable5
            // 
            this.ctrPoolTable5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrPoolTable5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrPoolTable5.HourlyRate = 10F;
            this.ctrPoolTable5.Location = new System.Drawing.Point(502, 331);
            this.ctrPoolTable5.Name = "ctrPoolTable5";
            this.ctrPoolTable5.PlayerName = "Player";
            this.ctrPoolTable5.Size = new System.Drawing.Size(509, 333);
            this.ctrPoolTable5.TabIndex = 4;
            this.ctrPoolTable5.TableName = "Tabel 1";
            this.ctrPoolTable5.EndTable += new System.EventHandler<PoolProject.ctrPoolTable.CompletedEventArgs>(this.ctrPoolTable1_EndTable);
            // 
            // ctrPoolTable6
            // 
            this.ctrPoolTable6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrPoolTable6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrPoolTable6.HourlyRate = 10F;
            this.ctrPoolTable6.Location = new System.Drawing.Point(-3, 331);
            this.ctrPoolTable6.Name = "ctrPoolTable6";
            this.ctrPoolTable6.PlayerName = "Player";
            this.ctrPoolTable6.Size = new System.Drawing.Size(509, 333);
            this.ctrPoolTable6.TabIndex = 3;
            this.ctrPoolTable6.TableName = "Tabel 1";
            this.ctrPoolTable6.EndTable += new System.EventHandler<PoolProject.ctrPoolTable.CompletedEventArgs>(this.ctrPoolTable1_EndTable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 664);
            this.Controls.Add(this.ctrPoolTable4);
            this.Controls.Add(this.ctrPoolTable5);
            this.Controls.Add(this.ctrPoolTable6);
            this.Controls.Add(this.ctrPoolTable3);
            this.Controls.Add(this.ctrPoolTable2);
            this.Controls.Add(this.ctrPoolTable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPoolTable ctrPoolTable1;
        private ctrPoolTable ctrPoolTable2;
        private ctrPoolTable ctrPoolTable3;
        private ctrPoolTable ctrPoolTable4;
        private ctrPoolTable ctrPoolTable5;
        private ctrPoolTable ctrPoolTable6;
    }
}

