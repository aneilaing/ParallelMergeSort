
using System;

namespace FinalProj_ParallelMergeSort
{
    partial class MainForm
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
            this.parButton = new System.Windows.Forms.Button();
            this.seqButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.namesRichText = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parButton
            // 
            this.parButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parButton.Location = new System.Drawing.Point(12, 64);
            this.parButton.Name = "parButton";
            this.parButton.Size = new System.Drawing.Size(88, 34);
            this.parButton.TabIndex = 0;
            this.parButton.Text = "Parallel";
            this.parButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.parButton.UseVisualStyleBackColor = true;
            this.parButton.Click += new System.EventHandler(this.parButton_Click);
            // 
            // seqButton
            // 
            this.seqButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seqButton.Location = new System.Drawing.Point(135, 64);
            this.seqButton.Name = "seqButton";
            this.seqButton.Size = new System.Drawing.Size(89, 34);
            this.seqButton.TabIndex = 1;
            this.seqButton.Text = "Sequential";
            this.seqButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.seqButton.UseVisualStyleBackColor = true;
            this.seqButton.Click += new System.EventHandler(this.seqButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(79, 158);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(80, 13);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Execution Time";
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(131, 429);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(93, 36);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View List";
            this.viewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // namesRichText
            // 
            this.namesRichText.Location = new System.Drawing.Point(82, 199);
            this.namesRichText.Name = "namesRichText";
            this.namesRichText.Size = new System.Drawing.Size(205, 212);
            this.namesRichText.TabIndex = 5;
            this.namesRichText.Text = "";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(260, 64);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 36);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset Sort";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(394, 491);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.namesRichText);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.seqButton);
            this.Controls.Add(this.parButton);
            this.Name = "MainForm";
            this.Text = "Parallel Merge Sort";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parButton;
        private System.Windows.Forms.Button seqButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button viewButton;
        //private EventHandler nameListBox_SelectedIndexChanged;
        private System.Windows.Forms.RichTextBox namesRichText;
        private System.Windows.Forms.Button resetButton;
    }
}

