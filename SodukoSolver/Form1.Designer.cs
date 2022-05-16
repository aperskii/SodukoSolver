
namespace SodukoSolver
{
    partial class Soduko
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this._solve = new System.Windows.Forms.Button();
            this._new = new System.Windows.Forms.Button();
            this.sudukoGrid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _solve
            // 
            this._solve.Location = new System.Drawing.Point(669, 175);
            this._solve.Name = "_solve";
            this._solve.Size = new System.Drawing.Size(75, 23);
            this._solve.TabIndex = 1;
            this._solve.Text = "Solve";
            this._solve.UseVisualStyleBackColor = true;
            this._solve.Click += new System.EventHandler(this._solve_Click);
            // 
            // _new
            // 
            this._new.Location = new System.Drawing.Point(669, 120);
            this._new.Name = "_new";
            this._new.Size = new System.Drawing.Size(75, 23);
            this._new.TabIndex = 2;
            this._new.Text = "New";
            this._new.UseVisualStyleBackColor = true;
            this._new.Click += new System.EventHandler(this._new_Click);
            // 
            // sudukoGrid
            // 
            this.sudukoGrid.Location = new System.Drawing.Point(589, 94);
            this.sudukoGrid.Name = "sudukoGrid";
            this.sudukoGrid.Size = new System.Drawing.Size(224, 20);
            this.sudukoGrid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Suduko grid";
            // 
            // Soduko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(825, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sudukoGrid);
            this.Controls.Add(this._new);
            this.Controls.Add(this._solve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Soduko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _solve;
        private System.Windows.Forms.Button _new;
        private System.Windows.Forms.TextBox sudukoGrid;
        private System.Windows.Forms.Label label1;
    }
}

