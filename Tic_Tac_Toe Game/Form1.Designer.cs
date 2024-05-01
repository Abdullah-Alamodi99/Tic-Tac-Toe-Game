
namespace Tic_Tac_Toe_Game
{
    partial class frmTicTackToeGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCell1 = new System.Windows.Forms.PictureBox();
            this.pbCell2 = new System.Windows.Forms.PictureBox();
            this.pbCell3 = new System.Windows.Forms.PictureBox();
            this.pbCell4 = new System.Windows.Forms.PictureBox();
            this.pbCell5 = new System.Windows.Forms.PictureBox();
            this.pbCell6 = new System.Windows.Forms.PictureBox();
            this.pbCell7 = new System.Windows.Forms.PictureBox();
            this.pbCell8 = new System.Windows.Forms.PictureBox();
            this.pbCell9 = new System.Windows.Forms.PictureBox();
            this.pnlCells = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell9)).BeginInit();
            this.pnlCells.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(31, 116);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(100, 29);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(32, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWinner.Location = new System.Drawing.Point(33, 210);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(136, 29);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.Black;
            this.btnResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.ForeColor = System.Drawing.Color.White;
            this.btnResetGame.Location = new System.Drawing.Point(36, 259);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(170, 45);
            this.btnResetGame.TabIndex = 5;
            this.btnResetGame.Text = "Restart Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Abdullah Al-Amodi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(459, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "coded by";
            // 
            // pbCell1
            // 
            this.pbCell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell1.Location = new System.Drawing.Point(66, 11);
            this.pbCell1.Name = "pbCell1";
            this.pbCell1.Size = new System.Drawing.Size(50, 50);
            this.pbCell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell1.TabIndex = 6;
            this.pbCell1.TabStop = false;
            this.pbCell1.Tag = "0,0";
            this.pbCell1.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell2
            // 
            this.pbCell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell2.Location = new System.Drawing.Point(166, 11);
            this.pbCell2.Name = "pbCell2";
            this.pbCell2.Size = new System.Drawing.Size(50, 50);
            this.pbCell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell2.TabIndex = 7;
            this.pbCell2.TabStop = false;
            this.pbCell2.Tag = "0,1";
            this.pbCell2.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell3
            // 
            this.pbCell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell3.Location = new System.Drawing.Point(266, 11);
            this.pbCell3.Name = "pbCell3";
            this.pbCell3.Size = new System.Drawing.Size(50, 50);
            this.pbCell3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell3.TabIndex = 8;
            this.pbCell3.TabStop = false;
            this.pbCell3.Tag = "0,2";
            this.pbCell3.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell4
            // 
            this.pbCell4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell4.Location = new System.Drawing.Point(66, 91);
            this.pbCell4.Name = "pbCell4";
            this.pbCell4.Size = new System.Drawing.Size(50, 50);
            this.pbCell4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell4.TabIndex = 9;
            this.pbCell4.TabStop = false;
            this.pbCell4.Tag = "1,0";
            this.pbCell4.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell5
            // 
            this.pbCell5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell5.Location = new System.Drawing.Point(166, 91);
            this.pbCell5.Name = "pbCell5";
            this.pbCell5.Size = new System.Drawing.Size(50, 50);
            this.pbCell5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell5.TabIndex = 10;
            this.pbCell5.TabStop = false;
            this.pbCell5.Tag = "1,1";
            this.pbCell5.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell6
            // 
            this.pbCell6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell6.Location = new System.Drawing.Point(266, 91);
            this.pbCell6.Name = "pbCell6";
            this.pbCell6.Size = new System.Drawing.Size(50, 50);
            this.pbCell6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell6.TabIndex = 11;
            this.pbCell6.TabStop = false;
            this.pbCell6.Tag = "1,2";
            this.pbCell6.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell7
            // 
            this.pbCell7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell7.Location = new System.Drawing.Point(66, 168);
            this.pbCell7.Name = "pbCell7";
            this.pbCell7.Size = new System.Drawing.Size(50, 50);
            this.pbCell7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell7.TabIndex = 12;
            this.pbCell7.TabStop = false;
            this.pbCell7.Tag = "2,0";
            this.pbCell7.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell8
            // 
            this.pbCell8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell8.Location = new System.Drawing.Point(166, 168);
            this.pbCell8.Name = "pbCell8";
            this.pbCell8.Size = new System.Drawing.Size(50, 50);
            this.pbCell8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell8.TabIndex = 13;
            this.pbCell8.TabStop = false;
            this.pbCell8.Tag = "2,1";
            this.pbCell8.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pbCell9
            // 
            this.pbCell9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCell9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pbCell9.Location = new System.Drawing.Point(266, 168);
            this.pbCell9.Name = "pbCell9";
            this.pbCell9.Size = new System.Drawing.Size(50, 50);
            this.pbCell9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell9.TabIndex = 14;
            this.pbCell9.TabStop = false;
            this.pbCell9.Tag = "2,2";
            this.pbCell9.Click += new System.EventHandler(this.Tic_Click);
            // 
            // pnlCells
            // 
            this.pnlCells.BackColor = System.Drawing.Color.Transparent;
            this.pnlCells.Controls.Add(this.pbCell5);
            this.pnlCells.Controls.Add(this.pbCell1);
            this.pnlCells.Controls.Add(this.pbCell2);
            this.pnlCells.Controls.Add(this.pbCell9);
            this.pnlCells.Controls.Add(this.pbCell3);
            this.pnlCells.Controls.Add(this.pbCell8);
            this.pnlCells.Controls.Add(this.pbCell4);
            this.pnlCells.Controls.Add(this.pbCell7);
            this.pnlCells.Controls.Add(this.pbCell6);
            this.pnlCells.Location = new System.Drawing.Point(359, 119);
            this.pnlCells.Name = "pnlCells";
            this.pnlCells.Size = new System.Drawing.Size(333, 232);
            this.pnlCells.TabIndex = 17;
            // 
            // frmTicTackToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(815, 442);
            this.Controls.Add(this.pnlCells);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmTicTackToeGame";
            this.Text = "Tic Tac Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCell1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell9)).EndInit();
            this.pnlCells.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbCell1;
        private System.Windows.Forms.PictureBox pbCell2;
        private System.Windows.Forms.PictureBox pbCell3;
        private System.Windows.Forms.PictureBox pbCell4;
        private System.Windows.Forms.PictureBox pbCell5;
        private System.Windows.Forms.PictureBox pbCell6;
        private System.Windows.Forms.PictureBox pbCell7;
        private System.Windows.Forms.PictureBox pbCell8;
        private System.Windows.Forms.PictureBox pbCell9;
        private System.Windows.Forms.Panel pnlCells;
    }
}

