using System.Windows.Forms;

namespace BaltbetProj
{
    partial class GeneralForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbBetsView = new System.Windows.Forms.TabPage();
            this.DGVbetsInDB = new System.Windows.Forms.DataGridView();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chbLoose = new System.Windows.Forms.CheckBox();
            this.chbWin = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rbRatioLess = new System.Windows.Forms.RadioButton();
            this.rbRatioMore = new System.Windows.Forms.RadioButton();
            this.rbRatioEx = new System.Windows.Forms.RadioButton();
            this.tbRatio = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbSummLess = new System.Windows.Forms.RadioButton();
            this.rbSummMore = new System.Windows.Forms.RadioButton();
            this.rbSummEx = new System.Windows.Forms.RadioButton();
            this.tbSummFilter = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbPrizeLess = new System.Windows.Forms.RadioButton();
            this.rbPrizeMore = new System.Windows.Forms.RadioButton();
            this.tbPrize = new System.Windows.Forms.TextBox();
            this.rbPrizeEx = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbDateSort = new System.Windows.Forms.CheckBox();
            this.DateTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBetId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.GeneralTab = new System.Windows.Forms.TabControl();
            this.tbPgBets = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnWithdrowAll = new System.Windows.Forms.Button();
            this.tbWithdraw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPutMoney = new System.Windows.Forms.TextBox();
            this.btnPutMoney = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBalanced1 = new System.Windows.Forms.Label();
            this.gbDeleteBets = new System.Windows.Forms.GroupBox();
            this.nudDelEvent = new System.Windows.Forms.NumericUpDown();
            this.btnClearList = new System.Windows.Forms.Button();
            this.nudDelExpress = new System.Windows.Forms.NumericUpDown();
            this.btnDelEvent = new System.Windows.Forms.Button();
            this.lblNumberExpress = new System.Windows.Forms.Label();
            this.btnDelExpress = new System.Windows.Forms.Button();
            this.lblNumberEvent = new System.Windows.Forms.Label();
            this.nudFullExpress = new System.Windows.Forms.NumericUpDown();
            this.gbBetsGeneric = new System.Windows.Forms.GroupBox();
            this.nadAddExpress = new System.Windows.Forms.NumericUpDown();
            this.lblAddExpress = new System.Windows.Forms.Label();
            this.btnAddExpress = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSummBet = new System.Windows.Forms.Label();
            this.btnMicroSave = new System.Windows.Forms.Button();
            this.tbOutcomes = new System.Windows.Forms.TextBox();
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.tbSummBet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOutcomes = new System.Windows.Forms.ListBox();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chbSuperBet = new System.Windows.Forms.CheckBox();
            this.rbSimpleBet = new System.Windows.Forms.RadioButton();
            this.rbExpressBet = new System.Windows.Forms.RadioButton();
            this.rbSystemBet = new System.Windows.Forms.RadioButton();
            this.btnLoadBets = new System.Windows.Forms.Button();
            this.DGVBets = new System.Windows.Forms.DataGridView();
            this.tbBetsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVbetsInDB)).BeginInit();
            this.Filters.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.tbPgBets.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDeleteBets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelExpress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFullExpress)).BeginInit();
            this.gbBetsGeneric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadAddExpress)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBets)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBetsView
            // 
            this.tbBetsView.Controls.Add(this.DGVbetsInDB);
            this.tbBetsView.Controls.Add(this.Filters);
            this.tbBetsView.Location = new System.Drawing.Point(4, 25);
            this.tbBetsView.Margin = new System.Windows.Forms.Padding(4);
            this.tbBetsView.Name = "tbBetsView";
            this.tbBetsView.Size = new System.Drawing.Size(1168, 447);
            this.tbBetsView.TabIndex = 2;
            this.tbBetsView.Text = "Обзор ставок";
            this.tbBetsView.UseVisualStyleBackColor = true;
            // 
            // DGVbetsInDB
            // 
            this.DGVbetsInDB.AllowUserToAddRows = false;
            this.DGVbetsInDB.AllowUserToDeleteRows = false;
            this.DGVbetsInDB.AllowUserToResizeColumns = false;
            this.DGVbetsInDB.AllowUserToResizeRows = false;
            this.DGVbetsInDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVbetsInDB.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVbetsInDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVbetsInDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 2.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVbetsInDB.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGVbetsInDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVbetsInDB.Location = new System.Drawing.Point(0, 0);
            this.DGVbetsInDB.Name = "DGVbetsInDB";
            this.DGVbetsInDB.ReadOnly = true;
            this.DGVbetsInDB.RowHeadersVisible = false;
            this.DGVbetsInDB.RowTemplate.Height = 24;
            this.DGVbetsInDB.RowTemplate.ReadOnly = true;
            this.DGVbetsInDB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVbetsInDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVbetsInDB.ShowCellErrors = false;
            this.DGVbetsInDB.ShowCellToolTips = false;
            this.DGVbetsInDB.ShowEditingIcon = false;
            this.DGVbetsInDB.ShowRowErrors = false;
            this.DGVbetsInDB.Size = new System.Drawing.Size(1168, 320);
            this.DGVbetsInDB.TabIndex = 0;
            // 
            // Filters
            // 
            this.Filters.Controls.Add(this.groupBox10);
            this.Filters.Controls.Add(this.groupBox9);
            this.Filters.Controls.Add(this.groupBox8);
            this.Filters.Controls.Add(this.groupBox7);
            this.Filters.Controls.Add(this.groupBox2);
            this.Filters.Controls.Add(this.groupBox1);
            this.Filters.Controls.Add(this.btnFind);
            this.Filters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Filters.Location = new System.Drawing.Point(0, 320);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(1168, 127);
            this.Filters.TabIndex = 3;
            this.Filters.TabStop = false;
            this.Filters.Text = "Фильтры";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox10.Controls.Add(this.chbLoose);
            this.groupBox10.Controls.Add(this.chbWin);
            this.groupBox10.Location = new System.Drawing.Point(998, 15);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(164, 71);
            this.groupBox10.TabIndex = 28;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Результат";
            // 
            // chbLoose
            // 
            this.chbLoose.AutoSize = true;
            this.chbLoose.Location = new System.Drawing.Point(33, 46);
            this.chbLoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.chbLoose.Name = "chbLoose";
            this.chbLoose.Size = new System.Drawing.Size(98, 21);
            this.chbLoose.TabIndex = 30;
            this.chbLoose.Text = "Проигрыш";
            this.chbLoose.UseVisualStyleBackColor = true;
            // 
            // chbWin
            // 
            this.chbWin.AutoSize = true;
            this.chbWin.Location = new System.Drawing.Point(33, 21);
            this.chbWin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.chbWin.Name = "chbWin";
            this.chbWin.Size = new System.Drawing.Size(91, 21);
            this.chbWin.TabIndex = 29;
            this.chbWin.Text = "Выигрыш";
            this.chbWin.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.rbRatioLess);
            this.groupBox9.Controls.Add(this.rbRatioMore);
            this.groupBox9.Controls.Add(this.rbRatioEx);
            this.groupBox9.Controls.Add(this.tbRatio);
            this.groupBox9.Location = new System.Drawing.Point(811, 15);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(181, 104);
            this.groupBox9.TabIndex = 27;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Коэффициент";
            // 
            // rbRatioLess
            // 
            this.rbRatioLess.AutoSize = true;
            this.rbRatioLess.Location = new System.Drawing.Point(94, 49);
            this.rbRatioLess.Name = "rbRatioLess";
            this.rbRatioLess.Size = new System.Drawing.Size(82, 21);
            this.rbRatioLess.TabIndex = 15;
            this.rbRatioLess.Text = "Меньше";
            this.rbRatioLess.UseVisualStyleBackColor = true;
            // 
            // rbRatioMore
            // 
            this.rbRatioMore.AutoSize = true;
            this.rbRatioMore.Location = new System.Drawing.Point(94, 76);
            this.rbRatioMore.Name = "rbRatioMore";
            this.rbRatioMore.Size = new System.Drawing.Size(80, 21);
            this.rbRatioMore.TabIndex = 16;
            this.rbRatioMore.Text = "Больше";
            this.rbRatioMore.UseVisualStyleBackColor = true;
            // 
            // rbRatioEx
            // 
            this.rbRatioEx.AutoSize = true;
            this.rbRatioEx.Checked = true;
            this.rbRatioEx.Location = new System.Drawing.Point(94, 22);
            this.rbRatioEx.Name = "rbRatioEx";
            this.rbRatioEx.Size = new System.Drawing.Size(70, 21);
            this.rbRatioEx.TabIndex = 14;
            this.rbRatioEx.TabStop = true;
            this.rbRatioEx.Text = "Точно";
            this.rbRatioEx.UseVisualStyleBackColor = true;
            // 
            // tbRatio
            // 
            this.tbRatio.Location = new System.Drawing.Point(6, 48);
            this.tbRatio.Name = "tbRatio";
            this.tbRatio.Size = new System.Drawing.Size(76, 22);
            this.tbRatio.TabIndex = 19;
            this.tbRatio.TextChanged += new System.EventHandler(this.tbRatio_TextChanged);
            this.tbRatio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRatio_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.rbSummLess);
            this.groupBox8.Controls.Add(this.rbSummMore);
            this.groupBox8.Controls.Add(this.rbSummEx);
            this.groupBox8.Controls.Add(this.tbSummFilter);
            this.groupBox8.Location = new System.Drawing.Point(624, 15);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(181, 104);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Сумма ставки";
            // 
            // rbSummLess
            // 
            this.rbSummLess.AutoSize = true;
            this.rbSummLess.Location = new System.Drawing.Point(94, 49);
            this.rbSummLess.Name = "rbSummLess";
            this.rbSummLess.Size = new System.Drawing.Size(82, 21);
            this.rbSummLess.TabIndex = 15;
            this.rbSummLess.Text = "Меньше";
            this.rbSummLess.UseVisualStyleBackColor = true;
            // 
            // rbSummMore
            // 
            this.rbSummMore.AutoSize = true;
            this.rbSummMore.Location = new System.Drawing.Point(94, 76);
            this.rbSummMore.Name = "rbSummMore";
            this.rbSummMore.Size = new System.Drawing.Size(80, 21);
            this.rbSummMore.TabIndex = 16;
            this.rbSummMore.Text = "Больше";
            this.rbSummMore.UseVisualStyleBackColor = true;
            // 
            // rbSummEx
            // 
            this.rbSummEx.AutoSize = true;
            this.rbSummEx.Checked = true;
            this.rbSummEx.Location = new System.Drawing.Point(94, 22);
            this.rbSummEx.Name = "rbSummEx";
            this.rbSummEx.Size = new System.Drawing.Size(70, 21);
            this.rbSummEx.TabIndex = 14;
            this.rbSummEx.TabStop = true;
            this.rbSummEx.Text = "Точно";
            this.rbSummEx.UseVisualStyleBackColor = true;
            // 
            // tbSummFilter
            // 
            this.tbSummFilter.Location = new System.Drawing.Point(6, 48);
            this.tbSummFilter.Name = "tbSummFilter";
            this.tbSummFilter.Size = new System.Drawing.Size(75, 22);
            this.tbSummFilter.TabIndex = 7;
            this.tbSummFilter.TextChanged += new System.EventHandler(this.tbSummFilter_TextChanged);
            this.tbSummFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSummFilter_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.rbPrizeLess);
            this.groupBox7.Controls.Add(this.rbPrizeMore);
            this.groupBox7.Controls.Add(this.tbPrize);
            this.groupBox7.Controls.Add(this.rbPrizeEx);
            this.groupBox7.Location = new System.Drawing.Point(437, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(181, 104);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Сумма выигрыша";
            // 
            // rbPrizeLess
            // 
            this.rbPrizeLess.AutoSize = true;
            this.rbPrizeLess.Location = new System.Drawing.Point(94, 49);
            this.rbPrizeLess.Name = "rbPrizeLess";
            this.rbPrizeLess.Size = new System.Drawing.Size(82, 21);
            this.rbPrizeLess.TabIndex = 15;
            this.rbPrizeLess.Text = "Меньше";
            this.rbPrizeLess.UseVisualStyleBackColor = true;
            // 
            // rbPrizeMore
            // 
            this.rbPrizeMore.AutoSize = true;
            this.rbPrizeMore.Location = new System.Drawing.Point(94, 76);
            this.rbPrizeMore.Name = "rbPrizeMore";
            this.rbPrizeMore.Size = new System.Drawing.Size(80, 21);
            this.rbPrizeMore.TabIndex = 16;
            this.rbPrizeMore.Text = "Больше";
            this.rbPrizeMore.UseVisualStyleBackColor = true;
            // 
            // tbPrize
            // 
            this.tbPrize.Location = new System.Drawing.Point(6, 48);
            this.tbPrize.Name = "tbPrize";
            this.tbPrize.Size = new System.Drawing.Size(75, 22);
            this.tbPrize.TabIndex = 13;
            this.tbPrize.TextChanged += new System.EventHandler(this.tbPrize_TextChanged);
            this.tbPrize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrize_KeyPress);
            // 
            // rbPrizeEx
            // 
            this.rbPrizeEx.AutoSize = true;
            this.rbPrizeEx.Checked = true;
            this.rbPrizeEx.Location = new System.Drawing.Point(94, 22);
            this.rbPrizeEx.Name = "rbPrizeEx";
            this.rbPrizeEx.Size = new System.Drawing.Size(70, 21);
            this.rbPrizeEx.TabIndex = 14;
            this.rbPrizeEx.TabStop = true;
            this.rbPrizeEx.Text = "Точно";
            this.rbPrizeEx.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.chbDateSort);
            this.groupBox2.Controls.Add(this.DateTP);
            this.groupBox2.Location = new System.Drawing.Point(218, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 104);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата";
            // 
            // chbDateSort
            // 
            this.chbDateSort.AutoSize = true;
            this.chbDateSort.Location = new System.Drawing.Point(6, 33);
            this.chbDateSort.Name = "chbDateSort";
            this.chbDateSort.Size = new System.Drawing.Size(177, 21);
            this.chbDateSort.TabIndex = 25;
            this.chbDateSort.Text = "Фильтровать по дате:";
            this.chbDateSort.UseVisualStyleBackColor = true;
            this.chbDateSort.CheckedChanged += new System.EventHandler(this.chbDateSort_CheckedChanged);
            // 
            // DateTP
            // 
            this.DateTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTP.Location = new System.Drawing.Point(6, 57);
            this.DateTP.Name = "DateTP";
            this.DateTP.Size = new System.Drawing.Size(200, 22);
            this.DateTP.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbBetId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbClientId);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 104);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Идентефикаторы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Ставки:";
            // 
            // tbBetId
            // 
            this.tbBetId.Location = new System.Drawing.Point(99, 31);
            this.tbBetId.Name = "tbBetId";
            this.tbBetId.Size = new System.Drawing.Size(99, 22);
            this.tbBetId.TabIndex = 1;
            this.tbBetId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBetId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Клиента:";
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(98, 57);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(100, 22);
            this.tbClientId.TabIndex = 3;
            this.tbClientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClientId_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFind.Location = new System.Drawing.Point(998, 91);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(164, 28);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Поиск...";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.tbPgBets);
            this.GeneralTab.Controls.Add(this.tbBetsView);
            this.GeneralTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralTab.Location = new System.Drawing.Point(0, 0);
            this.GeneralTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.SelectedIndex = 0;
            this.GeneralTab.Size = new System.Drawing.Size(1176, 476);
            this.GeneralTab.TabIndex = 9;
            this.GeneralTab.SelectedIndexChanged += new System.EventHandler(this.GeneralTab_SelectedIndexChanged);
            // 
            // tbPgBets
            // 
            this.tbPgBets.Controls.Add(this.groupBox4);
            this.tbPgBets.Controls.Add(this.groupBox5);
            this.tbPgBets.Controls.Add(this.groupBox3);
            this.tbPgBets.Controls.Add(this.gbDeleteBets);
            this.tbPgBets.Controls.Add(this.gbBetsGeneric);
            this.tbPgBets.Controls.Add(this.groupBox6);
            this.tbPgBets.Controls.Add(this.btnLoadBets);
            this.tbPgBets.Controls.Add(this.DGVBets);
            this.tbPgBets.Location = new System.Drawing.Point(4, 25);
            this.tbPgBets.Margin = new System.Windows.Forms.Padding(4);
            this.tbPgBets.Name = "tbPgBets";
            this.tbPgBets.Padding = new System.Windows.Forms.Padding(4);
            this.tbPgBets.Size = new System.Drawing.Size(1168, 447);
            this.tbPgBets.TabIndex = 1;
            this.tbPgBets.Text = "Ставки";
            this.tbPgBets.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnEnter);
            this.groupBox4.Controls.Add(this.tbId);
            this.groupBox4.Location = new System.Drawing.Point(9, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(364, 123);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление аккаунтом";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 68);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(315, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Выйти из аккаунта";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введи ID:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(241, 28);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 28);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 30);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(132, 22);
            this.tbId.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnWithdrowAll);
            this.groupBox5.Controls.Add(this.tbWithdraw);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbPutMoney);
            this.groupBox5.Controls.Add(this.btnPutMoney);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnWithdraw);
            this.groupBox5.Location = new System.Drawing.Point(381, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(396, 123);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление счетом";
            // 
            // btnWithdrowAll
            // 
            this.btnWithdrowAll.Location = new System.Drawing.Point(19, 87);
            this.btnWithdrowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdrowAll.Name = "btnWithdrowAll";
            this.btnWithdrowAll.Size = new System.Drawing.Size(361, 28);
            this.btnWithdrowAll.TabIndex = 11;
            this.btnWithdrowAll.Text = "Снять все деньги";
            this.btnWithdrowAll.UseVisualStyleBackColor = true;
            this.btnWithdrowAll.Click += new System.EventHandler(this.btnWithdrowAll_Click);
            // 
            // tbWithdraw
            // 
            this.tbWithdraw.Location = new System.Drawing.Point(139, 59);
            this.tbWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.tbWithdraw.Name = "tbWithdraw";
            this.tbWithdraw.Size = new System.Drawing.Size(132, 22);
            this.tbWithdraw.TabIndex = 10;
            this.tbWithdraw.Text = "0";
            this.tbWithdraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbWithdraw_MouseClick);
            this.tbWithdraw.TextChanged += new System.EventHandler(this.tbWithdraw_TextChanged);
            this.tbWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWithdraw_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пополнить счет:";
            // 
            // tbPutMoney
            // 
            this.tbPutMoney.Location = new System.Drawing.Point(139, 26);
            this.tbPutMoney.Margin = new System.Windows.Forms.Padding(4);
            this.tbPutMoney.Name = "tbPutMoney";
            this.tbPutMoney.Size = new System.Drawing.Size(132, 22);
            this.tbPutMoney.TabIndex = 9;
            this.tbPutMoney.Text = "0";
            this.tbPutMoney.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPutMoney_MouseClick);
            this.tbPutMoney.TextChanged += new System.EventHandler(this.tbPutMoney_TextChanged);
            this.tbPutMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPutMoney_KeyPress);
            // 
            // btnPutMoney
            // 
            this.btnPutMoney.Location = new System.Drawing.Point(280, 23);
            this.btnPutMoney.Margin = new System.Windows.Forms.Padding(4);
            this.btnPutMoney.Name = "btnPutMoney";
            this.btnPutMoney.Size = new System.Drawing.Size(100, 28);
            this.btnPutMoney.TabIndex = 6;
            this.btnPutMoney.Text = "Зачислить";
            this.btnPutMoney.UseVisualStyleBackColor = true;
            this.btnPutMoney.Click += new System.EventHandler(this.btnPutMoney_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Снять со счета:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(280, 57);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 28);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "Снять";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblBalanced1);
            this.groupBox3.Location = new System.Drawing.Point(785, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.MaximumSize = new System.Drawing.Size(370, 123);
            this.groupBox3.MinimumSize = new System.Drawing.Size(370, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(370, 123);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ваш счёт";
            // 
            // lblBalanced1
            // 
            this.lblBalanced1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanced1.AutoEllipsis = true;
            this.lblBalanced1.AutoSize = true;
            this.lblBalanced1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanced1.Location = new System.Drawing.Point(70, 42);
            this.lblBalanced1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalanced1.Name = "lblBalanced1";
            this.lblBalanced1.Size = new System.Drawing.Size(230, 39);
            this.lblBalanced1.TabIndex = 7;
            this.lblBalanced1.Text = "Ваш Баланс:";
            this.lblBalanced1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDeleteBets
            // 
            this.gbDeleteBets.Controls.Add(this.nudDelEvent);
            this.gbDeleteBets.Controls.Add(this.btnClearList);
            this.gbDeleteBets.Controls.Add(this.nudDelExpress);
            this.gbDeleteBets.Controls.Add(this.btnDelEvent);
            this.gbDeleteBets.Controls.Add(this.lblNumberExpress);
            this.gbDeleteBets.Controls.Add(this.btnDelExpress);
            this.gbDeleteBets.Controls.Add(this.lblNumberEvent);
            this.gbDeleteBets.Controls.Add(this.nudFullExpress);
            this.gbDeleteBets.Location = new System.Drawing.Point(9, 356);
            this.gbDeleteBets.Margin = new System.Windows.Forms.Padding(4);
            this.gbDeleteBets.Name = "gbDeleteBets";
            this.gbDeleteBets.Padding = new System.Windows.Forms.Padding(4);
            this.gbDeleteBets.Size = new System.Drawing.Size(432, 64);
            this.gbDeleteBets.TabIndex = 18;
            this.gbDeleteBets.TabStop = false;
            this.gbDeleteBets.Text = "Удаление ставок";
            // 
            // nudDelEvent
            // 
            this.nudDelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDelEvent.Location = new System.Drawing.Point(260, 27);
            this.nudDelEvent.Margin = new System.Windows.Forms.Padding(4);
            this.nudDelEvent.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelEvent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelEvent.Name = "nudDelEvent";
            this.nudDelEvent.Size = new System.Drawing.Size(160, 22);
            this.nudDelEvent.TabIndex = 27;
            this.nudDelEvent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(12, 27);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(408, 30);
            this.btnClearList.TabIndex = 22;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // nudDelExpress
            // 
            this.nudDelExpress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDelExpress.Location = new System.Drawing.Point(260, 62);
            this.nudDelExpress.Margin = new System.Windows.Forms.Padding(4);
            this.nudDelExpress.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelExpress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelExpress.Name = "nudDelExpress";
            this.nudDelExpress.Size = new System.Drawing.Size(160, 22);
            this.nudDelExpress.TabIndex = 26;
            this.nudDelExpress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelExpress.ValueChanged += new System.EventHandler(this.nudDelExpress_ValueChanged);
            // 
            // btnDelEvent
            // 
            this.btnDelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelEvent.Location = new System.Drawing.Point(12, 27);
            this.btnDelEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelEvent.Name = "btnDelEvent";
            this.btnDelEvent.Size = new System.Drawing.Size(87, 57);
            this.btnDelEvent.TabIndex = 20;
            this.btnDelEvent.Text = "Удалить событие";
            this.btnDelEvent.UseVisualStyleBackColor = true;
            this.btnDelEvent.Click += new System.EventHandler(this.btnDelEvent_Click);
            // 
            // lblNumberExpress
            // 
            this.lblNumberExpress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberExpress.AutoSize = true;
            this.lblNumberExpress.Location = new System.Drawing.Point(109, 64);
            this.lblNumberExpress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberExpress.Name = "lblNumberExpress";
            this.lblNumberExpress.Size = new System.Drawing.Size(126, 17);
            this.lblNumberExpress.TabIndex = 25;
            this.lblNumberExpress.Text = "Номер экспресса:";
            // 
            // btnDelExpress
            // 
            this.btnDelExpress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelExpress.Location = new System.Drawing.Point(12, 91);
            this.btnDelExpress.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelExpress.Name = "btnDelExpress";
            this.btnDelExpress.Size = new System.Drawing.Size(240, 30);
            this.btnDelExpress.TabIndex = 21;
            this.btnDelExpress.Text = "Удалить экспресс";
            this.btnDelExpress.UseVisualStyleBackColor = true;
            this.btnDelExpress.Click += new System.EventHandler(this.btnDelExpress_Click);
            // 
            // lblNumberEvent
            // 
            this.lblNumberEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberEvent.AutoSize = true;
            this.lblNumberEvent.Location = new System.Drawing.Point(109, 30);
            this.lblNumberEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberEvent.Name = "lblNumberEvent";
            this.lblNumberEvent.Size = new System.Drawing.Size(115, 17);
            this.lblNumberEvent.TabIndex = 24;
            this.lblNumberEvent.Text = "Номер события:";
            // 
            // nudFullExpress
            // 
            this.nudFullExpress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFullExpress.Location = new System.Drawing.Point(260, 94);
            this.nudFullExpress.Margin = new System.Windows.Forms.Padding(4);
            this.nudFullExpress.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFullExpress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFullExpress.Name = "nudFullExpress";
            this.nudFullExpress.Size = new System.Drawing.Size(160, 22);
            this.nudFullExpress.TabIndex = 23;
            this.nudFullExpress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbBetsGeneric
            // 
            this.gbBetsGeneric.Controls.Add(this.nadAddExpress);
            this.gbBetsGeneric.Controls.Add(this.lblAddExpress);
            this.gbBetsGeneric.Controls.Add(this.btnAddExpress);
            this.gbBetsGeneric.Controls.Add(this.lbl1);
            this.gbBetsGeneric.Controls.Add(this.lblSummBet);
            this.gbBetsGeneric.Controls.Add(this.btnMicroSave);
            this.gbBetsGeneric.Controls.Add(this.tbOutcomes);
            this.gbBetsGeneric.Controls.Add(this.tbEvents);
            this.gbBetsGeneric.Controls.Add(this.tbSummBet);
            this.gbBetsGeneric.Controls.Add(this.label6);
            this.gbBetsGeneric.Controls.Add(this.lbOutcomes);
            this.gbBetsGeneric.Controls.Add(this.lbEvents);
            this.gbBetsGeneric.Location = new System.Drawing.Point(9, 234);
            this.gbBetsGeneric.Margin = new System.Windows.Forms.Padding(4);
            this.gbBetsGeneric.Name = "gbBetsGeneric";
            this.gbBetsGeneric.Padding = new System.Windows.Forms.Padding(4);
            this.gbBetsGeneric.Size = new System.Drawing.Size(432, 114);
            this.gbBetsGeneric.TabIndex = 17;
            this.gbBetsGeneric.TabStop = false;
            this.gbBetsGeneric.Text = "Генерация ставки";
            // 
            // nadAddExpress
            // 
            this.nadAddExpress.Location = new System.Drawing.Point(260, 97);
            this.nadAddExpress.Margin = new System.Windows.Forms.Padding(4);
            this.nadAddExpress.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nadAddExpress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nadAddExpress.Name = "nadAddExpress";
            this.nadAddExpress.Size = new System.Drawing.Size(160, 22);
            this.nadAddExpress.TabIndex = 28;
            this.nadAddExpress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nadAddExpress.ValueChanged += new System.EventHandler(this.nadAddExpress_ValueChanged);
            // 
            // lblAddExpress
            // 
            this.lblAddExpress.AutoSize = true;
            this.lblAddExpress.Location = new System.Drawing.Point(16, 102);
            this.lblAddExpress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddExpress.Name = "lblAddExpress";
            this.lblAddExpress.Size = new System.Drawing.Size(228, 17);
            this.lblAddExpress.TabIndex = 19;
            this.lblAddExpress.Text = "Добавить событие в экспресс №:";
            // 
            // btnAddExpress
            // 
            this.btnAddExpress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddExpress.Location = new System.Drawing.Point(12, 162);
            this.btnAddExpress.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExpress.Name = "btnAddExpress";
            this.btnAddExpress.Size = new System.Drawing.Size(408, 30);
            this.btnAddExpress.TabIndex = 17;
            this.btnAddExpress.Text = "Добавить экспресс";
            this.btnAddExpress.UseVisualStyleBackColor = true;
            this.btnAddExpress.Click += new System.EventHandler(this.btnAddExpress_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(8, 23);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(70, 17);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Событие:";
            // 
            // lblSummBet
            // 
            this.lblSummBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummBet.AutoSize = true;
            this.lblSummBet.Location = new System.Drawing.Point(11, 53);
            this.lblSummBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummBet.Name = "lblSummBet";
            this.lblSummBet.Size = new System.Drawing.Size(102, 17);
            this.lblSummBet.TabIndex = 5;
            this.lblSummBet.Text = "Сумма ставки:";
            // 
            // btnMicroSave
            // 
            this.btnMicroSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMicroSave.Location = new System.Drawing.Point(12, 79);
            this.btnMicroSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnMicroSave.Name = "btnMicroSave";
            this.btnMicroSave.Size = new System.Drawing.Size(409, 30);
            this.btnMicroSave.TabIndex = 0;
            this.btnMicroSave.Text = "Сохранить событие";
            this.btnMicroSave.UseVisualStyleBackColor = true;
            this.btnMicroSave.Click += new System.EventHandler(this.btnMicroSave_Click);
            // 
            // tbOutcomes
            // 
            this.tbOutcomes.Location = new System.Drawing.Point(287, 20);
            this.tbOutcomes.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutcomes.Name = "tbOutcomes";
            this.tbOutcomes.Size = new System.Drawing.Size(132, 22);
            this.tbOutcomes.TabIndex = 16;
            // 
            // tbEvents
            // 
            this.tbEvents.Location = new System.Drawing.Point(83, 20);
            this.tbEvents.Margin = new System.Windows.Forms.Padding(4);
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(132, 22);
            this.tbEvents.TabIndex = 8;
            // 
            // tbSummBet
            // 
            this.tbSummBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSummBet.Location = new System.Drawing.Point(121, 50);
            this.tbSummBet.Margin = new System.Windows.Forms.Padding(4);
            this.tbSummBet.Name = "tbSummBet";
            this.tbSummBet.Size = new System.Drawing.Size(298, 22);
            this.tbSummBet.TabIndex = 6;
            this.tbSummBet.Text = "0";
            this.tbSummBet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSummBet_MouseClick);
            this.tbSummBet.TextChanged += new System.EventHandler(this.tbSummBet_TextChanged);
            this.tbSummBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSummBet_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Исход:";
            // 
            // lbOutcomes
            // 
            this.lbOutcomes.FormattingEnabled = true;
            this.lbOutcomes.ItemHeight = 16;
            this.lbOutcomes.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O"});
            this.lbOutcomes.Location = new System.Drawing.Point(287, 20);
            this.lbOutcomes.Margin = new System.Windows.Forms.Padding(4);
            this.lbOutcomes.Name = "lbOutcomes";
            this.lbOutcomes.Size = new System.Drawing.Size(132, 68);
            this.lbOutcomes.TabIndex = 14;
            this.lbOutcomes.Click += new System.EventHandler(this.lbOutcomes_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 16;
            this.lbEvents.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "P"});
            this.lbEvents.Location = new System.Drawing.Point(83, 20);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(132, 68);
            this.lbEvents.TabIndex = 3;
            this.lbEvents.Click += new System.EventHandler(this.lbEvents_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chbSuperBet);
            this.groupBox6.Controls.Add(this.rbSimpleBet);
            this.groupBox6.Controls.Add(this.rbExpressBet);
            this.groupBox6.Controls.Add(this.rbSystemBet);
            this.groupBox6.Location = new System.Drawing.Point(9, 138);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(432, 89);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Вид ставки";
            // 
            // chbSuperBet
            // 
            this.chbSuperBet.AutoSize = true;
            this.chbSuperBet.Location = new System.Drawing.Point(168, 48);
            this.chbSuperBet.Margin = new System.Windows.Forms.Padding(4);
            this.chbSuperBet.Name = "chbSuperBet";
            this.chbSuperBet.Size = new System.Drawing.Size(129, 21);
            this.chbSuperBet.TabIndex = 12;
            this.chbSuperBet.Text = "Суперэкспресс";
            this.chbSuperBet.UseVisualStyleBackColor = true;
            this.chbSuperBet.CheckedChanged += new System.EventHandler(this.chbSuperBet_CheckedChanged);
            // 
            // rbSimpleBet
            // 
            this.rbSimpleBet.AutoSize = true;
            this.rbSimpleBet.Checked = true;
            this.rbSimpleBet.Location = new System.Drawing.Point(20, 20);
            this.rbSimpleBet.Margin = new System.Windows.Forms.Padding(4);
            this.rbSimpleBet.Name = "rbSimpleBet";
            this.rbSimpleBet.Size = new System.Drawing.Size(90, 21);
            this.rbSimpleBet.TabIndex = 2;
            this.rbSimpleBet.TabStop = true;
            this.rbSimpleBet.Text = "Обычная";
            this.rbSimpleBet.UseVisualStyleBackColor = true;
            this.rbSimpleBet.CheckedChanged += new System.EventHandler(this.rbSimpleBet_CheckedChanged);
            this.rbSimpleBet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbSimpleBet_MouseDown);
            // 
            // rbExpressBet
            // 
            this.rbExpressBet.AutoSize = true;
            this.rbExpressBet.Location = new System.Drawing.Point(168, 20);
            this.rbExpressBet.Margin = new System.Windows.Forms.Padding(4);
            this.rbExpressBet.Name = "rbExpressBet";
            this.rbExpressBet.Size = new System.Drawing.Size(90, 21);
            this.rbExpressBet.TabIndex = 11;
            this.rbExpressBet.TabStop = true;
            this.rbExpressBet.Text = "Экспресс";
            this.rbExpressBet.UseVisualStyleBackColor = true;
            this.rbExpressBet.CheckedChanged += new System.EventHandler(this.rbExpressBet_CheckedChanged);
            this.rbExpressBet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbExpressBet_MouseDown);
            // 
            // rbSystemBet
            // 
            this.rbSystemBet.AutoSize = true;
            this.rbSystemBet.Location = new System.Drawing.Point(321, 20);
            this.rbSystemBet.Margin = new System.Windows.Forms.Padding(4);
            this.rbSystemBet.Name = "rbSystemBet";
            this.rbSystemBet.Size = new System.Drawing.Size(85, 21);
            this.rbSystemBet.TabIndex = 10;
            this.rbSystemBet.TabStop = true;
            this.rbSystemBet.Text = "Система";
            this.rbSystemBet.UseVisualStyleBackColor = true;
            this.rbSystemBet.CheckedChanged += new System.EventHandler(this.rbSystemBet_CheckedChanged);
            this.rbSystemBet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbSystemBet_MouseDown);
            // 
            // btnLoadBets
            // 
            this.btnLoadBets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadBets.Location = new System.Drawing.Point(446, 363);
            this.btnLoadBets.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadBets.Name = "btnLoadBets";
            this.btnLoadBets.Size = new System.Drawing.Size(711, 57);
            this.btnLoadBets.TabIndex = 9;
            this.btnLoadBets.Text = "Загрузить ставку";
            this.btnLoadBets.UseVisualStyleBackColor = true;
            this.btnLoadBets.Click += new System.EventHandler(this.btnLoadBets_Click);
            // 
            // DGVBets
            // 
            this.DGVBets.AllowUserToAddRows = false;
            this.DGVBets.AllowUserToDeleteRows = false;
            this.DGVBets.AllowUserToResizeColumns = false;
            this.DGVBets.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 2.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.DGVBets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVBets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGVBets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBets.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVBets.ColumnHeadersHeight = 40;
            this.DGVBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVBets.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGVBets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGVBets.Location = new System.Drawing.Point(449, 145);
            this.DGVBets.Margin = new System.Windows.Forms.Padding(4);
            this.DGVBets.MultiSelect = false;
            this.DGVBets.Name = "DGVBets";
            this.DGVBets.ReadOnly = true;
            this.DGVBets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVBets.RowHeadersVisible = false;
            this.DGVBets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVBets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVBets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVBets.ShowCellToolTips = false;
            this.DGVBets.Size = new System.Drawing.Size(711, 210);
            this.DGVBets.TabIndex = 3;
            this.DGVBets.TabStop = false;
            this.DGVBets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVBets_CellFormatting);
            this.DGVBets.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVBets_CellPainting);
            // 
            // GeneralForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1176, 476);
            this.Controls.Add(this.GeneralTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1194, 523);
            this.MinimumSize = new System.Drawing.Size(1194, 523);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BALTBET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.tbBetsView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVbetsInDB)).EndInit();
            this.Filters.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GeneralTab.ResumeLayout(false);
            this.tbPgBets.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbDeleteBets.ResumeLayout(false);
            this.gbDeleteBets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelExpress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFullExpress)).EndInit();
            this.gbBetsGeneric.ResumeLayout(false);
            this.gbBetsGeneric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadAddExpress)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tbBetsView;
        private System.Windows.Forms.TabControl GeneralTab;
        private System.Windows.Forms.TabPage tbPgBets;
        private System.Windows.Forms.RadioButton rbSystemBet;
        private System.Windows.Forms.RadioButton rbSimpleBet;
        private System.Windows.Forms.Button btnLoadBets;
        private System.Windows.Forms.TextBox tbEvents;
        private System.Windows.Forms.Button btnMicroSave;
        private System.Windows.Forms.Label lblSummBet;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbSummBet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBalanced1;
        private System.Windows.Forms.DataGridView DGVBets;
        private System.Windows.Forms.RadioButton rbExpressBet;
        private System.Windows.Forms.CheckBox chbSuperBet;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbDeleteBets;
        private System.Windows.Forms.GroupBox gbBetsGeneric;
        private System.Windows.Forms.TextBox tbOutcomes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbOutcomes;
        private System.Windows.Forms.Label lblAddExpress;
        private System.Windows.Forms.Button btnAddExpress;
        private System.Windows.Forms.Label lblNumberExpress;
        private System.Windows.Forms.Label lblNumberEvent;
        private System.Windows.Forms.NumericUpDown nudFullExpress;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnDelExpress;
        private System.Windows.Forms.Button btnDelEvent;
        private System.Windows.Forms.NumericUpDown nudDelEvent;
        private System.Windows.Forms.NumericUpDown nudDelExpress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnWithdrowAll;
        private System.Windows.Forms.TextBox tbWithdraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPutMoney;
        private System.Windows.Forms.Button btnPutMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.NumericUpDown nadAddExpress;
        private System.Windows.Forms.DataGridView DGVbetsInDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBetId;
        private System.Windows.Forms.TextBox tbPrize;
        private System.Windows.Forms.GroupBox Filters;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.TextBox tbSummFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRatio;
        private System.Windows.Forms.Button btnFind;
        private DateTimePicker DateTP;
        private GroupBox groupBox7;
        private RadioButton rbPrizeLess;
        private RadioButton rbPrizeMore;
        private RadioButton rbPrizeEx;
        private GroupBox groupBox2;
        private CheckBox chbDateSort;
        private GroupBox groupBox1;
        private CheckBox chbLoose;
        private CheckBox chbWin;
        private GroupBox groupBox10;
        private GroupBox groupBox9;
        private RadioButton rbRatioLess;
        private RadioButton rbRatioMore;
        private RadioButton rbRatioEx;
        private GroupBox groupBox8;
        private RadioButton rbSummLess;
        private RadioButton rbSummMore;
        private RadioButton rbSummEx;
    }
}

