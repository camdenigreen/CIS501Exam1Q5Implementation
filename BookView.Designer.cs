using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501Exam1Q5Implementation
{
    partial class BookView
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
            this.bookContentTextBox = new System.Windows.Forms.TextBox();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.goToPageTextbox = new System.Windows.Forms.TextBox();
            this.goToPageButton = new System.Windows.Forms.Button();
            this.bookmarkedCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bookContentTextBox
            // 
            this.bookContentTextBox.Location = new System.Drawing.Point(145, 3);
            this.bookContentTextBox.Multiline = true;
            this.bookContentTextBox.Name = "bookContentTextBox";
            this.bookContentTextBox.ReadOnly = true;
            this.bookContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookContentTextBox.Size = new System.Drawing.Size(536, 450);
            this.bookContentTextBox.TabIndex = 0;
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(39, 404);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(75, 23);
            this.previousPageButton.TabIndex = 1;
            this.previousPageButton.Text = "Previous";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(699, 404);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 2;
            this.nextPageButton.Text = "Next";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // goToPageTextbox
            // 
            this.goToPageTextbox.Location = new System.Drawing.Point(688, 78);
            this.goToPageTextbox.Name = "goToPageTextbox";
            this.goToPageTextbox.Size = new System.Drawing.Size(100, 22);
            this.goToPageTextbox.TabIndex = 3;
            // 
            // goToPageButton
            // 
            this.goToPageButton.Location = new System.Drawing.Point(687, 106);
            this.goToPageButton.Name = "goToPageButton";
            this.goToPageButton.Size = new System.Drawing.Size(101, 23);
            this.goToPageButton.TabIndex = 4;
            this.goToPageButton.Text = "Go To Page";
            this.goToPageButton.UseVisualStyleBackColor = true;
            this.goToPageButton.Click += new System.EventHandler(this.goToPageButton_Click);
            // 
            // bookmarkedCheckbox
            // 
            this.bookmarkedCheckbox.AutoSize = true;
            this.bookmarkedCheckbox.Location = new System.Drawing.Point(13, 58);
            this.bookmarkedCheckbox.Name = "bookmarkedCheckbox";
            this.bookmarkedCheckbox.Size = new System.Drawing.Size(107, 20);
            this.bookmarkedCheckbox.TabIndex = 5;
            this.bookmarkedCheckbox.Text = "Bookmarked";
            this.bookmarkedCheckbox.UseVisualStyleBackColor = true;
            this.bookmarkedCheckbox.Click += new System.EventHandler(this.bookmarkedCheckbox_CheckedChanged);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkedCheckbox);
            this.Controls.Add(this.goToPageButton);
            this.Controls.Add(this.goToPageTextbox);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.bookContentTextBox);
            this.Name = "BookView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox bookContentTextBox;
        private Button previousPageButton;
        private Button nextPageButton;
        private TextBox goToPageTextbox;
        private Button goToPageButton;
        private CheckBox bookmarkedCheckbox;
    }
}