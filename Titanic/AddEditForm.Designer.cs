namespace Titanic
{
    partial class AddEditForm
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
            comboBoxSurvived = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxClass = new ComboBox();
            textBoxName = new TextBox();
            label3 = new Label();
            comboBoxSex = new ComboBox();
            numericUpDownAge = new NumericUpDown();
            label4 = new Label();
            numericUpDownSibSp = new NumericUpDown();
            numericUpDownParch = new NumericUpDown();
            textBoxTicket = new TextBox();
            textBoxFare = new TextBox();
            textBoxCabin = new TextBox();
            comboBoxEmbarced = new ComboBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSibSp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownParch).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSurvived
            // 
            comboBoxSurvived.FormattingEnabled = true;
            comboBoxSurvived.Items.AddRange(new object[] { "Невыжил", "Выжил" });
            comboBoxSurvived.Location = new Point(12, 25);
            comboBoxSurvived.Name = "comboBoxSurvived";
            comboBoxSurvived.Size = new Size(175, 23);
            comboBoxSurvived.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Состояние";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Класс";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxClass.Location = new Point(12, 72);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(175, 23);
            comboBoxClass.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 111);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Сведения о пассажире";
            textBoxName.Size = new Size(175, 62);
            textBoxName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Пол";
            // 
            // comboBoxSex
            // 
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboBoxSex.Location = new Point(12, 195);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(175, 23);
            comboBoxSex.TabIndex = 6;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(12, 239);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(175, 23);
            numericUpDownAge.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Возраст";
            // 
            // numericUpDownSibSp
            // 
            numericUpDownSibSp.Location = new Point(220, 25);
            numericUpDownSibSp.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSibSp.Name = "numericUpDownSibSp";
            numericUpDownSibSp.Size = new Size(171, 23);
            numericUpDownSibSp.TabIndex = 9;
            // 
            // numericUpDownParch
            // 
            numericUpDownParch.Location = new Point(220, 72);
            numericUpDownParch.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownParch.Name = "numericUpDownParch";
            numericUpDownParch.Size = new Size(171, 23);
            numericUpDownParch.TabIndex = 10;
            // 
            // textBoxTicket
            // 
            textBoxTicket.Location = new Point(219, 110);
            textBoxTicket.Name = "textBoxTicket";
            textBoxTicket.PlaceholderText = "Номер билета";
            textBoxTicket.Size = new Size(172, 23);
            textBoxTicket.TabIndex = 11;
            // 
            // textBoxFare
            // 
            textBoxFare.Location = new Point(219, 150);
            textBoxFare.Name = "textBoxFare";
            textBoxFare.PlaceholderText = "Цена";
            textBoxFare.Size = new Size(172, 23);
            textBoxFare.TabIndex = 12;
            // 
            // textBoxCabin
            // 
            textBoxCabin.Location = new Point(219, 195);
            textBoxCabin.Name = "textBoxCabin";
            textBoxCabin.PlaceholderText = "Каюта";
            textBoxCabin.Size = new Size(172, 23);
            textBoxCabin.TabIndex = 13;
            // 
            // comboBoxEmbarced
            // 
            comboBoxEmbarced.FormattingEnabled = true;
            comboBoxEmbarced.Items.AddRange(new object[] { "C", "S", "Q" });
            comboBoxEmbarced.Location = new Point(220, 239);
            comboBoxEmbarced.Name = "comboBoxEmbarced";
            comboBoxEmbarced.Size = new Size(171, 23);
            comboBoxEmbarced.TabIndex = 14;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(65, 287);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 15;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(273, 287);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 333);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxEmbarced);
            Controls.Add(textBoxCabin);
            Controls.Add(textBoxFare);
            Controls.Add(textBoxTicket);
            Controls.Add(numericUpDownParch);
            Controls.Add(numericUpDownSibSp);
            Controls.Add(label4);
            Controls.Add(numericUpDownAge);
            Controls.Add(comboBoxSex);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxClass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxSurvived);
            Name = "AddEditForm";
            Text = "Информация о пассажире";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSibSp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownParch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public ComboBox comboBoxSurvived;
        public ComboBox comboBoxClass;
        public TextBox textBoxName;
        public ComboBox comboBoxSex;
        public NumericUpDown numericUpDownAge;
        public NumericUpDown numericUpDownSibSp;
        public NumericUpDown numericUpDownParch;
        public TextBox textBoxTicket;
        public TextBox textBoxFare;
        public TextBox textBoxCabin;
        public ComboBox comboBoxEmbarced;
        private Button buttonOk;
        public Button buttonCancel;
    }
}