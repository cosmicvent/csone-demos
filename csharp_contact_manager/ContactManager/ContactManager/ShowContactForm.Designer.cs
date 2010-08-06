namespace ContactManager {
    partial class ShowContactForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 21, 119 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 66, 13 );
            this.label4.TabIndex = 11;
            this.label4.Text = "Organization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 21, 93 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 32, 13 );
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 21, 67 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 58, 13 );
            this.label2.TabIndex = 9;
            this.label2.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 21, 41 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 35, 13 );
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Location = new System.Drawing.Point( 89, 116 );
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size( 168, 20 );
            this.organizationTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point( 89, 90 );
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size( 168, 20 );
            this.emailTextBox.TabIndex = 14;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point( 89, 64 );
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size( 168, 20 );
            this.telephoneTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point( 89, 38 );
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size( 168, 20 );
            this.nameTextBox.TabIndex = 12;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point( 24, 144 );
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size( 47, 23 );
            this.prevButton.TabIndex = 16;
            this.prevButton.Text = "<<Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler( this.prevButton_Click );
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point( 77, 144 );
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size( 50, 23 );
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "Next>>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler( this.nextButton_Click );
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point( 133, 144 );
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size( 53, 23 );
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler( this.deleteButton_Click );
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point( 21, 9 );
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size( 0, 13 );
            this.outputLabel.TabIndex = 19;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point( 192, 142 );
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size( 65, 23 );
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler( this.saveButton_Click );
            // 
            // ShowContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 287, 184 );
            this.Controls.Add( this.saveButton );
            this.Controls.Add( this.outputLabel );
            this.Controls.Add( this.deleteButton );
            this.Controls.Add( this.nextButton );
            this.Controls.Add( this.prevButton );
            this.Controls.Add( this.organizationTextBox );
            this.Controls.Add( this.emailTextBox );
            this.Controls.Add( this.telephoneTextBox );
            this.Controls.Add( this.nameTextBox );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label5 );
            this.Name = "ShowContactForm";
            this.Text = "ShowContactForm";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button saveButton;

    }
}