using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaltbetProj.ServiceReference1;

namespace BaltbetProj
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        //
        //  Константы таблицы
        //

        public Players GeneralPlayer = new Players();
        public List<Players> GeneralPlayers = new List<Players>();
        public Bets GeneralBet = new Bets();
        public List<Bets> GeneralBets = new List<Bets>();
        public const string FN = "BALTBET";
        public DataTable dt = new DataTable();
        public DataTable ExprsDT;
        public DataTable EventDT;
        public DataTable DeletedEvents = new DataTable();
        public DataTable BetsFromDB;
        public DataTable CommandsTable;
        public DataRow dataRow;
        public DataRow ExprsRow;
        public DataRow EventRow;
        public DateTime date = DateTime.Today;
        public Random ratio = new Random();

        //
        //  Функции
        //

        // ТАБЛИЦЫ
        //Инициализация таблицы BetsFromDB
        public void LoadBetsTable()
        {
            BetsFromDB = new DataTable();



            BetsFromDB.Columns.Add("ID Ставки", typeof(int));
            BetsFromDB.Columns.Add("ID Игрока", typeof(int));
            BetsFromDB.Columns.Add("Дата ставки", typeof(DateTime));
            BetsFromDB.Columns.Add("Сумма ставки", typeof(double));
            BetsFromDB.Columns.Add("Коэффициент", typeof(double));
            BetsFromDB.Columns.Add("Результат", typeof(int));
            BetsFromDB.Columns.Add("Выигрыш", typeof(double));
        }
        // Инициализация таблицы DeletedEvents
        public void LoadDelTable()
        {
            DataColumnCollection columns = EventDT.Columns;
            foreach (DataColumn column in columns)
            {
                DeletedEvents.Columns.Add(column.ColumnName, column.DataType);
            }
        }
        // Таблица SQL команд
        public void CommandsLoad()
        {
            CommandsTable = new DataTable();
            CommandsTable.Columns.Add("Команда 1", typeof(string));
            CommandsTable.Columns.Add("Последняя", typeof(bool));
        }
        // Инициализация таблиц экспрессов и событий
        public void LoadTable()
        {
            // Таблица экспрессов
            ExprsDT = new DataTable();
            ExprsDT.Columns.Add("Номер\nЭкспресса", typeof(int));
            ExprsDT.Columns.Add("Супер\nЭкспресс", typeof(int));
            ExprsDT.Columns.Add("Сумма\nСтавки", typeof(double));

            ExprsRow = ExprsDT.NewRow();

            ExprsRow = ExprsDT.NewRow();
            ExprsRow[0] = 1;
            ExprsRow[1] = 0;
            ExprsRow[2] = 0.00;
            ExprsDT.Rows.Add(ExprsRow);

            // Таблица событий
            EventDT = new DataTable();
            EventDT.Columns.Add("Номер\nЭкспресса", typeof(int));
            EventDT.Columns.Add("Дата", typeof(DateTime));
            EventDT.Columns.Add("Номер\nСобытия", typeof(int));
            EventDT.Columns.Add("Событие", typeof(string));
            EventDT.Columns.Add("Исход", typeof(string));
            EventDT.Columns.Add("Коэффициент", typeof(double));

            EventRow = EventDT.NewRow();

            EventRow[0] = 0;
            EventRow[1] = date.ToShortDateString();
            EventRow[2] = 1;
            EventRow[3] = "test";
            EventRow[4] = "tost";
            EventRow[5] = 0;

            EventDT.Rows.Add(EventRow);
        }
        // Конверт LINQ в DT
        public DataTable CreateDTfromLINQ(IEnumerable source)
        {
            var table = new DataTable();
            int index = 0;
            var properties = new List<PropertyInfo>();
            foreach (var obj in source)
            {
                if (index == 0)
                {
                    foreach (var property in obj.GetType().GetProperties())
                    {
                        if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                        {
                            continue;
                        }
                        properties.Add(property);
                        table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                    }
                }
                object[] values = new object[properties.Count];
                for (int i = 0; i < properties.Count; i++)
                {
                    values[i] = properties[i].GetValue(obj);
                }
                table.Rows.Add(values);
                index++;
            }
            return table;
        }
        // Запись в DeletedEvents
        public void DeletedEventsAdd(DataRow EvRow)
        {
            DataRow row = DeletedEvents.NewRow();

            for (int i = 0; i < EventDT.Columns.Count; i++)
            {
                if (i == 0)
                    row[i] = -1;
                else
                    row[i] = EvRow[i];
            }

            DeletedEvents.Rows.Add(row);
        }
        // --- --- --- --- --- --- --- --- ---

        // --- --- --- РАБОТА С БД --- --- ---
        // Загрузка ставки в БД
        public void BetLoad(Bets bet)
        {
            Service1Client service = new Service1Client();
            service.LoadBet(bet);
        }
        // Корректировка баланса в БД
        public void BalanceToDB(Players player)
        {
            Service1Client service = new Service1Client();
            service.UpdateBalance(player);
        }
        // Загрузка из БД таблицы с аккаунтами
        public void PlayersLoad()
        {
            Service1Client service = new Service1Client();
            foreach (Players player in service.GetPlayers())
            {
                GeneralPlayers.Add(player);
            }
        }
        // Вернуть команду запроса
        public string GetCommand()
        {
            CommandsLoad();
            string command = "SELECT * FROM BetsDB ";
            if (
                chbDateSort.Checked ||
                (chbWin.Checked ^
                chbLoose.Checked) ||
                (tbBetId.Text.Trim(' ').Length != 0) ||
                (tbClientId.Text.Trim(' ').Length != 0) ||
                (tbSummFilter.Text.Trim(' ').Length != 0) ||
                (tbRatio.Text.Trim(' ').Length != 0) ||
                (tbPrize.Text.Trim(' ').Length != 0))
                command = command + "WHERE ";
            else
                return command;

            if (tbBetId.Text.Trim(' ').Length != 0)
                CommandsTable.Rows.Add($"Id = {tbBetId.Text} ", false);
            if (tbClientId.Text.Trim(' ').Length != 0)
                CommandsTable.Rows.Add($"IdClien = {tbClientId.Text} ", false);
            if (chbDateSort.Checked)
                CommandsTable.Rows.Add($"Date = \'{Convert.ToDateTime(DateTP.Text.ToString()).ToShortDateString()}\' ", false);
            if (tbSummFilter.Text.Trim(' ').Length != 0)
            {
                if (rbSummEx.Checked)
                    CommandsTable.Rows.Add($"Summ = {tbSummFilter.Text} ", false);
                else if (rbSummLess.Checked)
                    CommandsTable.Rows.Add($"Summ < {tbSummFilter.Text} ", false);
                else if (rbSummMore.Checked)
                    CommandsTable.Rows.Add($"Summ > {tbSummFilter.Text} ", false);
            }
            if (tbRatio.Text.Trim(' ').Length != 0)
            {
                if (rbRatioEx.Checked)
                    CommandsTable.Rows.Add($"Ratio = {tbRatio.Text} ", false);
                else if (rbRatioLess.Checked)
                    CommandsTable.Rows.Add($"Ratio < {tbRatio.Text} ", false);
                else if (rbRatioMore.Checked)
                    CommandsTable.Rows.Add($"Ratio > {tbRatio.Text} ", false);
            }
            if (chbWin.Checked ^ chbLoose.Checked)
            {
                if (chbWin.Checked)
                    CommandsTable.Rows.Add($"Result = 1 ", false);
                else if (chbLoose.Checked)
                    CommandsTable.Rows.Add($"Result = 0 ", false);
            }
            if (tbPrize.Text.Trim(' ').Length != 0)
            {
                if (rbPrizeEx.Checked)
                    CommandsTable.Rows.Add($"Prise = {tbPrize.Text} ", false);
                else if (rbPrizeLess.Checked)
                    CommandsTable.Rows.Add($"Prise < {tbPrize.Text} ", false);
                else if (rbPrizeMore.Checked)
                    CommandsTable.Rows.Add($"Prise > {tbPrize.Text} ", false);
            }

            for (int i = (CommandsTable.Rows.Count - 1); i >= 0; i--)
            {
                if (i == (CommandsTable.Rows.Count - 1))
                {
                    CommandsTable.Rows[i][1] = true;
                }
                else
                {
                    CommandsTable.Rows[i][0] = CommandsTable.Rows[i][0] + "AND ";
                    CommandsTable.Rows[i][1] = false;
                }
            }

            foreach (DataRow row in CommandsTable.Rows)
                command = command + row[0];

            return command;
        }
        // --- --- --- --- --- --- --- --- ---

        // РЕГУЛИРОВКА СОСТОЯНИЙ
        // Загрузка состоянии в соответствии с активностью аккаунта
        public void StatusLoad()
        {
            if (GeneralPlayer.Name != null)
                Text = GeneralPlayer.Name.ToString() + " " + GeneralPlayer.Surname + "  -  " + FN;
            else
                Text = FN;
            BalanceStatusLoad();
            tbId.Clear();
            AttributeBet();
            ToolsEnable(Access());
            ValuesNUDs();
        }
        // Загрузка баланса
        public void BalanceStatusLoad()
        {           
            if(GeneralPlayer.Name != null)
            {
                BalanceToDB(GeneralPlayer);
            }

            if (GeneralPlayer.Balance == 0)
            {
                tbWithdraw.Enabled = false;
                btnWithdraw.Enabled = false;
                btnWithdrowAll.Enabled = false;
            }
            else
            {
                tbWithdraw.Enabled = true;
                btnWithdraw.Enabled = true;
                btnWithdrowAll.Enabled = true;
            }

            string balance = "Ваш баланс";

            if (GeneralPlayer.Name == null)
            {
                lblBalanced1.Text = balance;
            }
            else
            {
                lblBalanced1.Text = GeneralPlayer.Balance.ToString();
            }

            if (rbSimpleBet.Checked)
            {
                btnLoadBets.Location = new Point(337, 295);
            }
            else if (rbExpressBet.Checked)
            {
                btnLoadBets.Location = new Point(337, 322);
            }
            else
            {
                btnLoadBets.Location = new Point(337, 477);
            }

            tbWithdraw.Clear();
            tbPutMoney.Clear();
        }
        // Активность аккаунта
        public bool Access()
        {
            bool AccessFlag = false;            // Не доступен
            if (GeneralPlayer.Name != null)     // Если активен, возвратится True
                AccessFlag = true;
            return AccessFlag;
        }
        // Доступность клавиш (зависит от активности аккаунта)
        public void ToolsEnable(bool Flag)
        {
            tbWithdraw.Enabled = Flag; tbWithdraw.Clear();
            tbPutMoney.Enabled = Flag; tbPutMoney.Clear();
            btnWithdraw.Enabled = Flag;
            btnPutMoney.Enabled = Flag;
            btnWithdrowAll.Enabled = Flag;
            btnExit.Enabled = Flag;
            rbSimpleBet.Enabled = Flag; rbSimpleBet.Checked = true;
            rbExpressBet.Enabled = Flag; rbExpressBet.Checked = false;
            chbSuperBet.Checked = false;
            rbSystemBet.Enabled = Flag; rbSystemBet.Checked = false;
            lbEvents.Enabled = Flag;
            tbSummBet.Enabled = Flag;
            btnMicroSave.Enabled = Flag;
            btnLoadBets.Enabled = Flag;
            DGVBets.Enabled = Flag;
            tbEvents.Enabled = Flag;
            tbOutcomes.Enabled = Flag;
            btnDelEvent.Enabled = Flag;
            btnDelExpress.Enabled = Flag;
            btnClearList.Enabled = Flag;
            nudDelEvent.Enabled = Flag;
            nudDelExpress.Enabled = Flag;
            nudFullExpress.Enabled = Flag;
            BalanceStatusLoad();
        }
        // Чистота текстовых полей Ставок/Обзора ставок
        public void TBsClear()
        {
            tbEvents.Clear();
            tbOutcomes.Clear();
            lbEvents.ClearSelected();
            lbOutcomes.ClearSelected();
            TBSummIs();
        }
        public void TBsFromViewClear()
        {
            tbBetId.Clear();
            tbClientId.Clear();
            tbSummFilter.Clear();
            tbPrize.Clear();
            tbRatio.Clear();
            chbWin.Checked = false;
            chbLoose.Checked = false;
            chbDateSort.Checked = false;
        }       
        // Значение в тeкстбоксе "Cумма":
        public void TBSummIs()
        {
            int ExprsNow = Convert.ToInt32(nadAddExpress.Value);
            for (int i = 0; i < ExprsDT.Rows.Count; i++)
            {
                if (Convert.ToInt32(ExprsDT.Rows[i][0]) == ExprsNow)
                {
                    tbSummBet.Text = ExprsDT.Rows[i][2].ToString();
                    break;
                }                
            }
        }        
        // После изменения вида ставки
        public void AfterRBClick()
        {
            TBsClear();
            TBSummIs();
            DGVLoad();
            ValuesNUDs();
        }
        // Зависимости от радиокнопок
        public void AttributeBet()
        {
            if (rbSimpleBet.Checked)
            {
                #region Настройки видимости и доступности
                chbSuperBet.Enabled = false;             // Доступность суперэкспресса
                chbSuperBet.Checked = false;             // Отменить выбор суперэкспресса

                // Видимость атрибутов системы
                lbEvents.Visible = false;
                lbOutcomes.Visible = false;

                // Видимость атрибутов экспресса
                chbSuperBet.Checked = false;
                lblAddExpress.Visible = false;
                nadAddExpress.Visible = false;
                btnAddExpress.Visible = false;

                // Видимость атрибутов не системы
                tbEvents.Visible = true;
                tbOutcomes.Visible = true;

                // Видимости элементов "Удаления ставок"
                btnDelEvent.Visible = false;
                btnDelExpress.Visible = false;
                nudDelEvent.Visible = false;
                nudDelExpress.Visible = false;
                nudFullExpress.Visible = false;
                lblNumberEvent.Visible = false;
                lblNumberExpress.Visible = false;

                // Надписи...
                btnClearList.Text = "Удалить ставку";
                lblSummBet.Text = "Сумма ставки:";
                #endregion

                // Настройки панели Генерация ставки
                gbBetsGeneric.Size = new Size(324, 93);
                btnMicroSave.Location = new Point(9, 64);
                lblSummBet.Location = new Point(8, 43);
                tbSummBet.Location = new Point(98, 40);
                tbSummBet.Size = new Size(217, 22);

                // Настройки панели Удаление ставок
                btnClearList.Location = new Point(9, 22);
                gbDeleteBets.Size = new Size(324, 52);
                gbDeleteBets.Location = new Point(7, 289);

                // Кнопка загрузка ставки в БД, Таблица, Главная форма
                btnLoadBets.Location = new Point(337, 295);
                DGVBets.Size = new Size(533, 171);
                Point CSize = new Point(900, 414);
                MinimumSize = new Size(CSize);
                MaximumSize = new Size(CSize);
                ClientSize = new Size(CSize);

                AfterRBClick();
            }
            else if (rbExpressBet.Checked)
            {
                #region Настройки видимости и доступности
                // Доступность суперэкспресса
                chbSuperBet.Enabled = true;

                // Видимость атрибутов системы
                lbEvents.Visible = false;
                lbOutcomes.Visible = false;

                // Видимость атрибутов экспресса
                lblAddExpress.Visible = false;
                nadAddExpress.Visible = false;
                btnAddExpress.Visible = false;

                // Видимость атрибутов не системы
                tbEvents.Visible = true;
                tbOutcomes.Visible = true;

                // Видимости элемнетов "Удаления ставок"
                btnDelEvent.Visible = true;
                btnDelExpress.Visible = false;
                nudDelEvent.Visible = true;
                nudDelExpress.Visible = false;
                nudFullExpress.Visible = false;
                lblNumberEvent.Visible = true;
                lblNumberExpress.Visible = false;


                // Надписи...
                btnClearList.Text = "Удалить ставку";
                lblNumberEvent.Text = "Событие:";
                lblSummBet.Text = "Сумма экспресса:";
                #endregion

                // Настройки панели Генерация ставки
                gbBetsGeneric.Size = new Size(324, 93);
                btnMicroSave.Location = new Point(9, 64);
                lblSummBet.Location = new Point(8, 43);
                tbSummBet.Location = new Point(118, 40);
                tbSummBet.Size = new Size(197, 22);

                // Настройки панели Удаление ставок
                btnDelEvent.Size = new Size(100, 24);
                btnDelEvent.Location = new Point(11, 22);
                lblNumberEvent.Location = new Point(135, 27);
                nudDelEvent.Location = new Point(195, 24);
                btnClearList.Location = new Point(9, 50);
                gbDeleteBets.Size = new Size(324, 79);
                gbDeleteBets.Location = new Point(7, 289);

                // Кнопка загрузка ставки в БД, Таблица, Главная форма                
                btnLoadBets.Location = new Point(336, 322);
                DGVBets.Size = new Size(533, 198);
                Point CSize = new Point(900, 442);
                MinimumSize = new Size(CSize);
                MaximumSize = new Size(CSize);
                ClientSize = new Size(CSize);

                AfterRBClick();
            }
            else if (rbSystemBet.Checked)
            {
                #region Настройки видимости и доступности
                chbSuperBet.Enabled = false;             // Доступность суперэкспресса
                chbSuperBet.Checked = false;
                chbSuperBet.Enabled = false;             // Отменить выбор суперэкспресса

                // Видимость атрибутов системы
                lbEvents.Visible = true;
                lbOutcomes.Visible = true;

                // Видимость атрибутов экспресса
                lblAddExpress.Visible = true;
                nadAddExpress.Visible = true;
                btnAddExpress.Visible = true;

                // Видимость атрибутов не системы
                tbEvents.Visible = false;
                tbOutcomes.Visible = false;

                // Видимости элемнетов "Удаления ставок"
                btnDelEvent.Visible = true;
                btnDelExpress.Visible = true;
                nudDelEvent.Visible = true;
                nudDelExpress.Visible = true;
                nudFullExpress.Visible = true;
                lblNumberEvent.Visible = true;
                lblNumberExpress.Visible = true;


                // Надписи...
                btnClearList.Text = "Удалить все ставки";
                btnDelEvent.Text = "Удалить событие";
                lblSummBet.Text = "Сумма экспресса:";
                #endregion

                // Настройки панели Генерация ставки
                gbBetsGeneric.Size = new Size(324, 193);
                btnMicroSave.Location = new Point(9, 162);
                lblSummBet.Location = new Point(8, 109);
                tbSummBet.Location = new Point(118, 106);
                tbSummBet.Size = new Size(197, 22);
                btnAddExpress.Location = new Point(9, 132);

                // Настройки панели Удаление ставок
                gbDeleteBets.Size = new Size(324, 134);
                btnClearList.Location = new Point(9, 104);
                btnDelEvent.Location = new Point(9, 22);
                btnDelEvent.Size = new Size(65, 46);
                btnDelExpress.Location = new Point(9, 74);
                lblNumberExpress.Location = new Point(82, 52);
                lblNumberEvent.Location = new Point(82, 24);
                nudDelEvent.Location = new Point(195, 22);
                nudDelExpress.Location = new Point(195, 50);
                nudFullExpress.Location = new Point(195, 76);
                gbDeleteBets.Location = new Point(7, 389);

                // Кнопка загрузка ставки в БД, Таблица, Главная форма
                btnLoadBets.Location = new Point(336, 477);
                DGVBets.Size = new Size(533, 353);
                Point CSize = new Point(900, 595);
                MinimumSize = new Size(CSize);
                MaximumSize = new Size(CSize);
                ClientSize = new Size(CSize);

                AfterRBClick();
            }
        }
        // Максимальные значения NUDов
        public void ValuesNUDs()
        {
            int MaxValue = 1;
            int MaxEventValue = 1;
            if (Access())
            {
                MaxValue = MaxExprs();
                MaxEventValue = MaxDelEvent();
            }
            else
            {
                MaxValue = 1;
                MaxEventValue = 1;
            }
            nudDelExpress.Maximum = MaxValue;
            nadAddExpress.Maximum = MaxValue;
            nudFullExpress.Maximum = MaxValue;
            nudDelEvent.Maximum = MaxEventValue;
            nudDelEvent.Minimum = 1;
        }
        // Настройка DGV
        public void DGVLoad()
        {
            var AllInTable = (from Ex in ExprsDT.AsEnumerable()
                              join Ev in EventDT.AsEnumerable()
                              on Ex.Field<int>("Номер\nЭкспресса")
                              equals Ev.Field<int>("Номер\nЭкспресса")
                              select new
                              {
                                  DateComm = Ev.Field<DateTime>("Дата"),
                                  SupBet = Ex.Field<int>("Супер\nЭкспресс"),
                                  ExprsNumEX = Ex.Field<int>("Номер\nЭкспресса"),
                                  EventNum = Ev.Field<int>("Номер\nСобытия"),
                                  EvenT = Ev.Field<string>("Событие"),
                                  OutCome = Ev.Field<string>("Исход"),
                                  RatiO = Ev.Field<double>("Коэффициент"),
                                  SummBet = Ex.Field<double>("Сумма\nСтавки")
                              }).ToList();


            dt = CreateDTfromLINQ(AllInTable);

            DGVBets.DataSource = dt;


            // Настройка вида
            if (DGVBets.Columns.Count > 0)
            {
                DGVBets.Columns[0].HeaderText = "Дата";
                DGVBets.Columns[1].HeaderText = "Супер\nЭкспресс";
                DGVBets.Columns[2].HeaderText = "Номер\nЭкспресса";
                DGVBets.Columns[3].HeaderText = "Номер\nСобытия";
                DGVBets.Columns[4].HeaderText = "Событие";
                DGVBets.Columns[5].HeaderText = "Исход";

                for (int i = 0; i < DGVBets.Columns.Count; i++)
                {
                    DGVBets.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                DGVBets.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVBets.FirstDisplayedScrollingRowIndex = DGVBets.RowCount - 1;


                if (rbSimpleBet.Checked)
                {
                    DGVBets.Columns[0].Visible = true;
                    DGVBets.Columns[1].Visible = false;
                    DGVBets.Columns[2].Visible = false;
                    DGVBets.Columns[3].Visible = false;
                    DGVBets.Columns[4].Visible = true;
                    DGVBets.Columns[5].Visible = true;
                    DGVBets.Columns[6].Visible = true;
                    DGVBets.Columns[6].HeaderText = "Коэффициент";
                    DGVBets.Columns[7].Visible = true;
                    DGVBets.Columns[7].HeaderText = "Сумма ставки";
                }
                else if (rbExpressBet.Checked)
                {
                    DGVBets.Columns[0].Visible = true;
                    DGVBets.Columns[1].Visible = true;
                    DGVBets.Columns[2].Visible = false;
                    DGVBets.Columns[3].Visible = true;
                    DGVBets.Columns[4].Visible = true;
                    DGVBets.Columns[5].Visible = true;
                    DGVBets.Columns[6].Visible = true;
                    DGVBets.Columns[6].HeaderText = "Коэффициент";
                    DGVBets.Columns[7].Visible = true;
                    DGVBets.Columns[7].HeaderText = "Сумма\nСтавки";
                }
                else if (rbSystemBet.Checked)
                {
                    DGVBets.Columns[0].Visible = true;
                    DGVBets.Columns[1].Visible = false;
                    DGVBets.Columns[2].Visible = true;
                    DGVBets.Columns[3].Visible = true;
                    DGVBets.Columns[4].Visible = true;
                    DGVBets.Columns[5].Visible = true;
                    DGVBets.Columns[6].Visible = true;
                    DGVBets.Columns[6].HeaderText = "Коэффициент";
                    DGVBets.Columns[7].Visible = true;
                    DGVBets.Columns[7].HeaderText = "Сумма\nСтавки";
                }
            }
        }
        // Для перерисовки DGV
        bool isthesamecellvalue(int column, int row)
        {
            DataGridViewCell cell1 = DGVBets[column, row];
            DataGridViewCell cell2 = DGVBets[column, row - 1];

            DataGridViewCell cell3 = DGVBets[2, row];
            DataGridViewCell cell4 = DGVBets[2, row - 1];

            if (
                (column == 0 |
                column == 1 |
                column == 2 |
                column == 7) &&
                (cell3.Value.ToString() == cell4.Value.ToString()))
            {
                if (cell1.Value == null || cell2.Value == null)
                {
                    return false;
                }

                return cell1.Value.ToString() == cell2.Value.ToString();
            }
            else
                return false;
        }
        // Настройка DGVfromDB
        public void DGVfromBetsDB(string command)
        {
            LoadBetsTable();
            LoadBets(command);
            if (BetsFromDB.Rows.Count == 0)
                OkMSG("Ничего не найдено!");
            DGVbetsInDB.DataSource = BetsFromDB;

            if (DGVbetsInDB.Columns.Count > 0)
            {
                for (int i = 0; i < DGVBets.Columns.Count; i++)
                {
                    DGVbetsInDB.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
                }

                DGVbetsInDB.Columns[0].HeaderText = "ID Ставки";
                DGVbetsInDB.Columns[1].HeaderText = "ID Клиента";
                DGVbetsInDB.Columns[2].HeaderText = "Дата";
                DGVbetsInDB.Columns[3].HeaderText = "Сумма ставки";
                DGVbetsInDB.Columns[4].HeaderText = "Коэффициент";
                DGVbetsInDB.Columns[5].HeaderText = "Результат";
                DGVbetsInDB.Columns[6].HeaderText = "Сумма выигрыша";
            }

        }
        // --- --- --- --- --- --- --- --- ---

        // ГЕНЕРАЦИЯ СТАВОК
        // Максимальный номер экспресса
        public int MaxExprs()
        {
            int MaxExprs = 0;
            for (int i = 0; i < ExprsDT.Rows.Count; i++)
            {
                if (Convert.ToInt32(ExprsDT.Rows[i][0]) >= MaxExprs)
                    MaxExprs = Convert.ToInt32(ExprsDT.Rows[i][0]);
            }
            return MaxExprs;
        }
        // Количество событий в экспрессе
        public int CountEventsInExprs(int ExprsNow)
        {
            int CountEv = 0;
            foreach (DataRow row in EventDT.Rows)
                if (Convert.ToInt32(row[0]) == ExprsNow)
                    CountEv++;
            return CountEv;
        }
        // Максимальный номер события экспресса
        public int MaxEvent(int ExprsNow)
        {
            int MaxEvent = 0;
            for (int i = 0; i < EventDT.Rows.Count; i++)
            {
                if (Convert.ToInt32(EventDT.Rows[i][0]) == ExprsNow)
                {
                    if (Convert.ToInt32(EventDT.Rows[i][2]) >= MaxEvent)
                        MaxEvent = Convert.ToInt32(EventDT.Rows[i][2]);
                }
            }
            return MaxEvent;
        }
        // Возвратить строку событий
        public DataRow ReturnEv(int ExprsNow, int EventNow)
        {
            DataRow EvRow = EventDT.NewRow();
            foreach (DataRow row in EventDT.Rows)
                if (
                    (Convert.ToInt32(row[0]) == ExprsNow) &&
                    (Convert.ToInt32(row[2]) == EventNow))
                    EvRow = row;
            if (EvRow[5].ToString() == "")
            {
                return null;
            }
            else
                return EvRow;
        }
        // Поиск повторяющихся событий
        public DataRow SearchRepEventRow()
        {
            DataRow data = EventDT.NewRow();
            string EventNow = tbEvents.Text.ToLower();
            string OutComeNow = tbOutcomes.Text.ToLower();

            // Среди существующих
            foreach (DataRow row in EventDT.Rows)
            {
                if ((row[3].ToString().ToLower() == EventNow) &&
                    (row[4].ToString().ToLower() == OutComeNow))
                {
                    data = row;
                    break;
                }
            }
            // Среди удаленных
            if (
                data.IsNull(0) &&
                (DeletedEvents.Rows.Count > 0))
            {
                foreach (DataRow row in DeletedEvents.Rows)
                {
                    if ((row[3].ToString().ToLower() == EventNow) &&
                        (row[4].ToString().ToLower() == OutComeNow))
                    {
                        data = row;
                        break;
                    }
                }
            }
            return data;
        }
        // Уменьшение счета
        public void BalanceSubtraction(double subtrahend)
        {
            if (GeneralPlayer.Balance >= subtrahend)
            {
                GeneralPlayer.Balance -= subtrahend;
                //BalanceToDB(GeneralPlayer);
            }
            else MessageBox.Show(
                "Недостаточно средств на счёте!!!",
                "BALTBET",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        // --- --- --- --- --- --- --- --- ---

        // УДАЛЕНИЕ СТАВОК
        // Максимальный номер события экспресса()
        public int MaxDelEvent()
        {
            int MaxDelEvent = 0;
            int ExprsNow = Convert.ToInt32(nudDelExpress.Value);
            for (int i = 0; i < EventDT.Rows.Count; i++)
            {
                if (Convert.ToInt32(EventDT.Rows[i][0]) == ExprsNow)
                {
                    if (Convert.ToInt32(EventDT.Rows[i][2]) >= MaxDelEvent)
                        MaxDelEvent = Convert.ToInt32(EventDT.Rows[i][2]);
                }
            }
            return MaxDelEvent;
        }
        // Удаление всех событий в экспрессе
        public void DeleteEventsOfExprs(int Exprs)
        {
            for (int i = (EventDT.Rows.Count - 1); i >= 1; i--)
            {
                if (Convert.ToInt32(EventDT.Rows[i][0]) == Exprs)
                {
                    DeletedEventsAdd(EventDT.Rows[i]);
                    EventDT.Rows[i].Delete();
                }
            }
        }
        // --- --- --- --- --- --- --- --- ---

        // РАСЧЕТ СТАВКИ
        // Проверка ставок на соответствие перед ИГРОЙ
        public double FindErr()
        {
            double ok = 0;

            // Проверка на наличие экспрессов
            if (dt.Rows.Count == 0)
                return ok = 1;

            // Проверка на ноль в сумме ставки
            if (Convert.ToInt32(ExprsDT.Rows[MaxExprs() - 1][2]) == 0)
                return ok = 2;

            // Проверка на отсутствие событий в экспрессе
            var distinctsEx = dt.AsEnumerable().
                Select(s => new
                {
                    Ex = s.Field<int>(2),
                }).Distinct().Count().ToString();
            int ExprsS = Convert.ToInt32(distinctsEx);
            if (ExprsDT.Rows.Count != ExprsS)
                return ok = 3;

            // Проверка на достаточность средств
            double summMoney = 0;
            for (int i = (ExprsDT.Rows.Count - 1); i >= 0; i--)
            {
                summMoney += Convert.ToInt32(ExprsDT.Rows[i][2]);
            }
            if ((GeneralPlayer.Balance - summMoney) < 0)
                return ok = GeneralPlayer.Balance - summMoney;

            return ok;
        }
        // Победил/проиграл
        public int Win()
        {
            if (ratio.Next(0, 10) > 4)
                return 1;
            else
                return 0;
        }
        // Произведение коэффициентов по экспрессу
        public double GetMultiRatio(int Exprs)
        {
            double GetResult = 1;

            for(int i = MaxEvent(Exprs); i >= 1; i--)
            {
                GetResult *= Convert.ToDouble(ReturnEv(Exprs, i)[5]);                
            }

            return GetResult;
        }
        // Загрузка ставок из БД в таблицу
        public void LoadBets(string Command)
        {
            Service1Client service = new Service1Client();
            foreach (Bets bet in service.GetBets(Command))
            {
                DataRow row = BetsFromDB.NewRow();
                row[0] = bet.Id;
                row[1] = bet.IdClient;
                row[2] = Convert.ToDateTime(bet.Date).ToShortDateString();
                row[3] = bet.Summ;
                row[4] = bet.Ratio;
                row[5] = bet.Result;
                row[6] = bet.Prise;
                BetsFromDB.Rows.Add(row);
            }
        }
        // --- --- --- --- --- --- --- --- ---

        // СООБЩЕНИЯ
        public void OkMSG(string text)
        {
            MessageBox.Show(text, "BALTBET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void WarningMSG(string text)
        {
            MessageBox.Show(text, "BALTBET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // --- --- --- --- --- --- --- --- ---

        // ВЫХОД ИЗ АККАУНТА
        public void Exit()
        {
            if (dt.Rows.Count > 0)
            {
                var result = MessageBox.Show(
                    "У Вас есть незавершенные ставки!!!" +
                    "\n\nПродолжить выход???",
                    "BALTBET",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    btnLoadBets.Focus();
                else
                {
                    for (int i = (EventDT.Rows.Count - 1); i >= 1; i--)
                    {
                        DeletedEventsAdd(EventDT.Rows[i]);
                    }

                    GeneralPlayer = new Players();
                    LoadTable();
                    DGVLoad();
                    StatusLoad();
                }
            }
            else
            {
                for (int i = (EventDT.Rows.Count - 1); i >= 1; i--)
                {
                    DeletedEventsAdd(EventDT.Rows[i]);
                }

                GeneralPlayer = new Players();
                LoadTable();
                DGVLoad();
                StatusLoad();
            }
        }
        // ----------------------------------------------------------

        //
        //  Кнопки + события
        //

        // Старт
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadDelTable();
            ToolsEnable(Access());            
            AttributeBet();                        
        }

        // Вход в аккаунт
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(tbId.Text);
                PlayersLoad();
                foreach (Players player in GeneralPlayers)
                {
                    if (Id == player.Id)
                    {
                        GeneralPlayer.Id = player.Id;
                        GeneralPlayer.Surname = player.Surname;
                        GeneralPlayer.Name = player.Name;
                        GeneralPlayer.Patronymic = player.Patronymic;
                        GeneralPlayer.Birth = player.Birth;
                        GeneralPlayer.Balance = player.Balance;
                    }
                }
                if (GeneralPlayer.Id != Id)
                {
                    WarningMSG("Вы не зарегестрированы!\nПожалуйста, авторизуйтесь.");
                    
                    for(int i = (EventDT.Rows.Count - 1); i >= 1; i--)
                    {
                        DeletedEventsAdd(EventDT.Rows[i]);
                    }

                    GeneralPlayer = new Players();
                    LoadTable();
                    DGVLoad();
                }
                StatusLoad();
            }
            catch
            {
                if (tbId.Text == "")
                {
                    WarningMSG("Введите идентефикатор пользователя!!!");
                }
                else
                    WarningMSG("Идентефикатор пользователя\nсостоит только из цифр!!!");
            }
                       
        }

        // Снять со счёта
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                BalanceSubtraction(Convert.ToDouble(tbWithdraw.Text));
                BalanceStatusLoad();
            }
            catch
            {
                WarningMSG("Введите сумму!!!");
            }            
        }

        // Снять всё со счета
        private void btnWithdrowAll_Click(object sender, EventArgs e)
        {
            GeneralPlayer.Balance = 0;
            BalanceStatusLoad();
        }

        // Пополнить счёт
        private void btnPutMoney_Click(object sender, EventArgs e)
        {
            try
            {
                double numer = double.Parse(tbPutMoney.Text);
                GeneralPlayer.Balance += numer;
                BalanceStatusLoad();
                if (lblBalanced1.Size.Width > 175)
                {
                    lblBalanced1.Font = new Font(
                        lblBalanced1.Font.Name,
                        lblBalanced1.Font.Size - 5,
                        lblBalanced1.Font.Style);
                }
            }
            catch
            {
                WarningMSG("Введите сумму!!!");
            }            
        }

        // Выход из аккаунта
        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        
        // Определение размера выигрыша и загрузка ставки в базу        
        private void btnLoadBets_Click(object sender, EventArgs e)
        {
            double ok = FindErr();
            if (ok < 0)
            {
                OkMSG(
                    $"Недостаточно {Math.Abs(ok)} на счете!!!\n" +
                    "Чтобы продолжить, пожалуйста, пополните счет");
                tbPutMoney.Text = Math.Abs(ok).ToString();
                btnPutMoney.Focus();
            }
            else if (ok == 1)
            {
                OkMSG("Необходимо добавить события!!!");
            }
            else if (ok == 2)
            {
                OkMSG(
                    "Сумма последнего экспресса равна нулю!!!\n" +
                    "Пожалуйста, введите сумму ставки");
                tbSummBet.SelectAll();
            }
            else if (ok == 3)
            {
                OkMSG("В \"Системе\" присутствует экспресс без событий!!!");
            }
            else if (ok == 0)
            {
                double TotalWinSumm = 0;
                double WinSumm = 0; 
                double BetSumm = 0;
                double RatiO = 0;

                                
                BalanceStatusLoad();
                TBsClear();

                for (int i = 0; i < ExprsDT.Rows.Count; i++)
                {
                    BetSumm = Convert.ToDouble(ExprsDT.Rows[i][2]);
                    BalanceSubtraction(BetSumm);
                    RatiO = GetMultiRatio(Convert.ToInt32(ExprsDT.Rows[i][0]));

                    WinSumm = (RatiO * BetSumm * Win());

                    GeneralBet.IdClient = GeneralPlayer.Id;
                    GeneralBet.Date = date.ToString();
                    GeneralBet.Summ = BetSumm;
                    GeneralBet.Ratio = RatiO;
                    if (WinSumm == 0)
                        GeneralBet.Result = 0;
                    else if (WinSumm > 0)
                        GeneralBet.Result = 1;
                    GeneralBet.Prise = WinSumm;
                    BetLoad(GeneralBet);

                    GeneralBet = new Bets();

                    TotalWinSumm += WinSumm;                    
                }

                if (TotalWinSumm > 0)
                {
                    OkMSG($"Поздравляем!!!\nВаш выигрыш составил: {TotalWinSumm}");
                    TotalWinSumm = Math.Round(TotalWinSumm, 2, MidpointRounding.AwayFromZero);
                    GeneralPlayer.Balance += TotalWinSumm;                    
                }
                else if (TotalWinSumm == 0)
                {                    
                    OkMSG("К сожалению Вы проиграли...");
                }

                BalanceStatusLoad();
                LoadTable();
                ValuesNUDs();
                DGVLoad();                
            }
            else
                OkMSG("Неизвестная ошибка!!!");
        }


        // Настройка вида ставки радиокнопками    
        private void rbExpressBet_CheckedChanged(object sender, EventArgs e)
        {
            AttributeBet();
        }        
        private void rbSimpleBet_CheckedChanged(object sender, EventArgs e)
        {
            AttributeBet();
        }
        private void rbSystemBet_CheckedChanged(object sender, EventArgs e)
        {
            AttributeBet();
        }
        //        

        // Запись события
        private void btnMicroSave_Click(object sender, EventArgs e)
        {
            int ExprsNow = Convert.ToInt32(nadAddExpress.Value);
            if (rbSimpleBet.Checked && (CountEventsInExprs(1) == 1))
            {
                var result = MessageBox.Show(
                    "Количество событий в обычной ставке - одно!!!\n" +
                    "Желаете переключиться в \"Экспресс-режим?\"",
                    "BALTBET",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string Ev = tbEvents.Text;
                    string OutCome = tbOutcomes.Text;
                    rbExpressBet.Checked = true;
                    tbEvents.Text = Ev;
                    tbOutcomes.Text = OutCome;
                }
                else if (result == DialogResult.No)
                    TBsClear();
            }
            else if (
                rbSystemBet.Checked &&
                (CountEventsInExprs(Convert.ToInt32(nadAddExpress.Value)) == 16))
            {
                MessageBox.Show(
                    "В режиме \"Система\" не допускается\n" +
                    "сохранять в экспресс более 16 событий.\n" +
                    "Попробуйте сохранить событие в другой\n" +
                    "экспресс.", "BALTBET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(SearchRepEventRow()[5].ToString() != "")
            {
                DataRow RepeatEvent = SearchRepEventRow();                

                if (Convert.ToInt32(RepeatEvent[0]) == ExprsNow)
                {
                    MessageBox.Show(
                    "Запись двух одинаковых событий с равным\n" +
                    "исходом в один экспресс невозможа.\n" +
                    "Попробуйте сохранить событие в другой\n" +
                    "экспресс.", "BALTBET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Convert.ToInt32(RepeatEvent[0]) != ExprsNow)
                {                    
                    EventRow = EventDT.NewRow();

                    EventRow[0] = Convert.ToInt32(nadAddExpress.Value);
                    EventRow[1] = RepeatEvent[1];
                    EventRow[2] = MaxEvent(ExprsNow) + 1;
                    EventRow[3] = tbEvents.Text;
                    EventRow[4] = tbOutcomes.Text;
                    EventRow[5] = RepeatEvent[5];
                    
                    EventDT.Rows.Add(EventRow);

                    ValuesNUDs();
                    TBsClear();
                    DGVLoad();
                }
            }
            else
            {
                if ((tbSummBet.Text == "" & tbEvents.Text == "") ||
                    (tbOutcomes.Text == "" & tbSummBet.Text == "") ||
                    (tbEvents.Text == "" & tbOutcomes.Text == "")) MessageBox.Show("Заполните необходимые поля", "BALTBET",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbSummBet.Text == "") MessageBox.Show("Введите сумму", "BALTBET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbEvents.Text == "") MessageBox.Show("Выберите событие", "BALTBET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbOutcomes.Text == "") MessageBox.Show("Выберите исход события", "BALTBET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    EventRow = EventDT.NewRow();

                    EventRow[0] = Convert.ToInt32(nadAddExpress.Value);
                    EventRow[1] = date.ToShortDateString();
                    EventRow[2] = MaxEvent(ExprsNow) + 1;
                    EventRow[3] = tbEvents.Text;
                    EventRow[4] = tbOutcomes.Text;
                    EventRow[5] = Math.Round((ratio.Next(1, 20) + ratio.NextDouble()), 3, MidpointRounding.AwayFromZero);

                    EventDT.Rows.Add(EventRow);

                    ValuesNUDs();
                    TBsClear();
                    DGVLoad();
                }
            }
        }

        // Запись экспресса
        private void btnAddExpress_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(tbSummBet.Text) == 0)
            {
                WarningMSG("Введите сумму ставки!");
            }
            else if (rbSystemBet.Checked && (MaxExprs() == 1001))
                MessageBox.Show("Максимально возможное количество\n" +
                    "экспрессов в системе - 1001!",
                    "BALTBET",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                ExprsDT.NewRow();

                ExprsRow = ExprsDT.NewRow();
                ExprsRow[0] = MaxExprs() + 1;
                ExprsRow[1] = 0;
                ExprsRow[2] = 0.00;
                ExprsDT.Rows.Add(ExprsRow);               

                ValuesNUDs();               

                nadAddExpress.Value = MaxExprs();
                TBSummIs();
            }
        }

        // Копирование из листбокса в текстбокс
        private void lbEvents_Click(object sender, EventArgs e)
        {
            tbEvents.Text = lbEvents.Text;
        }        
        private void lbOutcomes_Click(object sender, EventArgs e)
        {
            tbOutcomes.Text = lbOutcomes.Text;
        }
        //

        // Изменение номера экспресса в который добавляется событие
        private void nadAddExpress_ValueChanged(object sender, EventArgs e)
        {            
            TBSummIs();
        }        

        // Изменение суммы по экспрессу или ставке 
        private void tbSummBet_TextChanged(object sender, EventArgs e)
        {
            tbSummBet.Text = tbSummBet.Text.Replace(".", ",");
            if (tbSummBet.Text == "")
                tbSummBet.Text = "0";
            tbSummBet.SelectionStart = tbSummBet.Text.Length;
            int CntStr = tbSummBet.Text.Length - 1;
            bool ok = true;
            char ZPT = ',';
            if (tbSummBet.Text[CntStr] == ZPT)
                ok = false;
            if (ok)
            {
                double i = Convert.ToDouble(tbSummBet.Text);

                ExprsDT.Rows[Convert.ToInt32(nadAddExpress.Value - 1)][2] = i;
                DGVLoad();

                TBSummIs();
            }
        }

        // Супертираж добавить/удалить
        private void chbSuperBet_CheckedChanged(object sender, EventArgs e)
        {
            if(chbSuperBet.Checked)
                ExprsDT.Rows[Convert.ToInt32(nadAddExpress.Value - 1)][1] = 1;
            else
                ExprsDT.Rows[Convert.ToInt32(nadAddExpress.Value - 1)][1] = 0;
            DGVLoad();
        }

        // Выделение текста в textbox
        private void tbSummBet_MouseClick(object sender, MouseEventArgs e)
        {
            tbSummBet.SelectAll();
        }
        private void tbPutMoney_MouseClick(object sender, MouseEventArgs e)
        {
            tbPutMoney.SelectAll();
        }
        private void tbWithdraw_MouseClick(object sender, MouseEventArgs e)
        {
            tbWithdraw.SelectAll();
        }
        //

        // Перебор экспресса в котором удаляется событие
        private void nudDelExpress_ValueChanged(object sender, EventArgs e)
        {
            nudDelEvent.Value = 1;
            ValuesNUDs();
        }

        // Удалить все экспрессы и все ставки
        private void btnClearList_Click(object sender, EventArgs e)
        {
            for(int i = (EventDT.Rows.Count - 1); i > 0; i--)
            {
                DeletedEventsAdd(EventDT.Rows[i]);
            }

            TBsClear();
            LoadTable();
            ValuesNUDs();
            DGVLoad();            
        }

        // Удаленние экспресса и событий в экспрессе
        private void btnDelExpress_Click(object sender, EventArgs e)
        {
            // Если существует единственный экспресс
            if (ExprsDT.Rows.Count < 2)
            {                
                for(int i = 1; i <= MaxEvent(1); i--)
                {
                    DeletedEventsAdd(ReturnEv(1, i));                 
                } 

                LoadTable();
                ValuesNUDs();
                TBsClear();
                DGVLoad();
            }
            // Если экспрессов много
            else
            {
                OkMSG("2");

                int ExprsDelNow = Convert.ToInt32(nudFullExpress.Value);
                OkMSG(nudFullExpress.Value.ToString());

                OkMSG(EventDT.Rows.Count.ToString());
                DeleteEventsOfExprs(ExprsDelNow);
                OkMSG(EventDT.Rows.Count.ToString());


                for (int i = (ExprsDT.Rows.Count - 1); i >= 0; i--)
                {
                    if(Convert.ToInt32(ExprsDT.Rows[i][0]) == ExprsDelNow)
                    {                        
                        ExprsDT.Rows[i].Delete();
                    }
                }
                
                // Если экспресс был не последний
                if (ExprsDelNow != MaxExprs())
                {
                    int ExprsNum = 1;
                    foreach (DataRow row in ExprsDT.Rows)
                    {
                        row[0] = ExprsNum;
                        ExprsNum++;
                    }

                    for (int i = 1; i < EventDT.Rows.Count; i++)
                    {
                        if(Convert.ToInt32(EventDT.Rows[i][0]) >= ExprsDelNow)
                        {
                            int x = Convert.ToInt32(EventDT.Rows[i][0]) - ExprsDelNow - 1;
                            EventDT.Rows[i][0] = ExprsDelNow + x;
                        }                        
                    }
                }
                                
                ValuesNUDs();
                TBsClear();
                DGVLoad();
            }
        }

        // Удаление события из экспресса
        private void btnDelEvent_Click(object sender, EventArgs e)
        {
            int ExprsDelNow = Convert.ToInt32(nudDelExpress.Value);
            int EventDelNow = Convert.ToInt32(nudDelEvent.Value);
            int CountEvents = CountEventsInExprs(ExprsDelNow);            

            // Если существует всего один экспресс с одним событием
            if (CountEvents == 1 && ExprsDT.Rows.Count == 1)
            {
                DeletedEventsAdd(ReturnEv(ExprsDelNow, EventDelNow));

                LoadTable();
                ValuesNUDs();
                TBsClear();
                DGVLoad();
            }    
            // Если в экспрессе всего одно событие
            else if (CountEvents == 1)
            {
                for(int i = 0; i < EventDT.Rows.Count; i++)
                {
                    if (
                        (Convert.ToInt32(EventDT.Rows[i][0]) == ExprsDelNow) && 
                        (Convert.ToInt32(EventDT.Rows[i][2]) == EventDelNow))
                    {
                        DeletedEventsAdd(EventDT.Rows[i]);
                        EventDT.Rows[i].Delete();
                    }
                        
                }
                for(int i = 0; i < ExprsDT.Rows.Count; i++)
                {
                    if (Convert.ToInt32(ExprsDT.Rows[i][0]) == ExprsDelNow)
                        ExprsDT.Rows[i].Delete();
                }
                                
                int ExprsNum = 1;
                // Переназначение номеров экспрессам
                foreach (DataRow row in ExprsDT.Rows) 
                {
                    row[0] = ExprsNum;
                    ExprsNum++;
                }
                // Переназначение номеров экспрессов в событиях
                for (int i = 0; i < EventDT.Rows.Count; i++)
                {
                    if (Convert.ToInt32(EventDT.Rows[i][0]) >= ExprsDelNow)
                    {
                        int x = Convert.ToInt32(EventDT.Rows[i][0]) - ExprsDelNow - 1;
                        EventDT.Rows[i][0] = ExprsDelNow + x;
                    }
                }

                TBsClear();                
                DGVLoad();
                ValuesNUDs();
            }
            else
            {
                for (int i = 0; i < EventDT.Rows.Count; i++)
                {
                    if (
                        (Convert.ToInt32(EventDT.Rows[i][0]) == ExprsDelNow) &&
                        (Convert.ToInt32(EventDT.Rows[i][2]) == EventDelNow))
                    {
                        DeletedEventsAdd(EventDT.Rows[i]);
                        EventDT.Rows[i].Delete();
                    }
                        
                }
                
                int EventNum = 1;
                if (EventDelNow != MaxEvent(ExprsDelNow))
                {
                    for (int i = 0; i < EventDT.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(EventDT.Rows[i][0]) == ExprsDelNow)
                        {
                            EventDT.Rows[i][2] = EventNum;
                            EventNum++;
                        }
                    }
                }

                ValuesNUDs();
                TBsClear();
                DGVLoad();
            }                       
        }
 
        // Выбор режима
        private void rbExpressBet_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbSystemBet.Checked)
            {
                if((ExprsDT.Rows.Count > 1))
                {
                    string mess =
                    "При выборе режима \"Экспресс-ставка\"\n" +
                    "будут удалены все экспрессы кроме\n" +
                    "первого.\n\nПродолжить?";
                    string capt = "BALTBET";
                    var result = MessageBox.Show(
                        mess,
                        capt,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        rbExpressBet.Checked = true;

                        // Удаление экспрессов
                        for (int i = (ExprsDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (Convert.ToInt32(ExprsDT.Rows[i][0]) > 1)
                                ExprsDT.Rows[i].Delete();
                        }

                        // Удаление событий удаленных экспрессов
                        for(int i = (EventDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (Convert.ToInt32(EventDT.Rows[i][0]) > 1)
                                EventDT.Rows[i].Delete();
                        }

                        ValuesNUDs();
                        TBsClear();
                        DGVLoad();
                    }
                }
            }            
        }
        private void rbSimpleBet_MouseDown(object sender, MouseEventArgs e)
        {
            string mess;
            string capt = "BALTBET";            
            int CountEv = 0;
            int CountEx = 0;
            foreach(DataRow row in ExprsDT.Rows)
            {
                CountEx++;
            }
            foreach(DataRow row in EventDT.Rows)
            {
                if (Convert.ToInt32(row[0]) == 1)
                    CountEv++;
            }

            if (rbSystemBet.Checked)
            {
                if ((CountEx > 1) && (CountEv == 1))
                {
                    mess =
                    "При выборе режима \"Обычная ставка\"\n" +
                    "будут удалены все экспрессы кроме\n" +
                    "первого.\n\nПродолжить?";
                    var result = MessageBox.Show(
                        mess,
                        capt,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        rbSimpleBet.Checked = true;

                        // Удаление экспрессов
                        for (int i = (ExprsDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (Convert.ToInt32(ExprsDT.Rows[i][0]) > 1)
                                ExprsDT.Rows[i].Delete();
                        }

                        // Удаление событий удаленных экспрессов
                        for (int i = (EventDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (Convert.ToInt32(EventDT.Rows[i][0]) > 1)
                                EventDT.Rows[i].Delete();
                        }

                        ValuesNUDs();
                        TBsClear();
                        DGVLoad();
                    }

                }
                else if ((CountEv > 1) && (CountEx > 1))
                {
                    mess =
                        "При выборе режима \"Обычная ставка\"\n" +
                        "будут удалены все экспрессы кроме\n" +
                        "первого и все события первого экспресса\n" +
                        "кроме первого.\n\nПродолжить?";
                    var result1 = MessageBox.Show(
                        mess,
                        capt,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result1 == DialogResult.Yes)
                    {
                        rbSimpleBet.Checked = true;

                        // Удаление экспрессов
                        for (int i = (ExprsDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (Convert.ToInt32(ExprsDT.Rows[i][0]) > 1)
                                ExprsDT.Rows[i].Delete();
                        }

                        // Удаление событий удаленных экспрессов и все, кроме первого, события первого экспресса
                        for (int i = (EventDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (i > 1)
                                EventDT.Rows[i].Delete();
                        }

                        ValuesNUDs();
                        TBsClear();
                        DGVLoad();
                    }
                }
                else if ((CountEv > 1) && (CountEx == 1))
                {
                    mess =
                    "При выборе режима \"Обычная ставка\"\n" +
                    "будут удалены все события первого\n" +
                    "экспресса, кроме первого.\n\nПродолжить?";
                    var result2 = MessageBox.Show(
                        mess,
                        capt,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        rbSimpleBet.Checked = true;

                        // Удаление событий первого экспресса, кроме первого
                        for (int i = (EventDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (i > 1)
                                EventDT.Rows[i].Delete();
                        }

                        ValuesNUDs();
                        TBsClear();
                        DGVLoad();
                    }

                }
            }
            else if (rbExpressBet.Checked)
            {

                if (CountEv > 1)
                {
                    mess =
                        "При выборе режима \"Обычная ставка\"\n" +
                        "будут удалены все события экспресса,\n" +
                        "кроме первого.\n\nПродолжить?";
                    var result3 = MessageBox.Show(
                        mess,
                        capt,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result3 == DialogResult.Yes)
                    {
                         rbSimpleBet.Checked = true;

                        // Удаление событий первого экспресса, кроме первого
                        for (int i = (EventDT.Rows.Count - 1); i >= 0; i--)
                        {
                            if (i > 1)
                                EventDT.Rows[i].Delete();
                        }

                        ValuesNUDs();
                        TBsClear();
                        DGVLoad();
                    }
                }
            }
        }
        private void rbSystemBet_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbExpressBet.Checked)
            {
                int CountEvent = CountEventsInExprs(1);
                                
                if (chbSuperBet.Checked)
                {
                    string mess;
                    string capt = "BALTBET";

                    mess =
                        "При выборе режима \"Система\"\n" +
                        "будет отменен суперэкспресс." +
                        "\n\nПродолжить?";
                    var result = MessageBox.Show(
                        mess,
                        capt,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (CountEvent > 16)
                        {
                            var resultX = MessageBox.Show(
                           "При режиме \"Система\" максимально возможное\n" +
                           "количество событий в экспрессе - 16!!!\n" +
                           "При переходе в режим \"Система\" события\n" +
                           "с номером больше 16 будут стёрты.\n\nПродолжить?",
                           "BALTBET",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information);
                            if (resultX == DialogResult.Yes)
                            {
                                for (int i = (EventDT.Rows.Count - 1); i >= 0; i--)
                                {
                                    if ((Convert.ToInt32(EventDT.Rows[i][0]) == 1) &&
                                        (Convert.ToInt32(EventDT.Rows[i][2]) > 16))
                                        EventDT.Rows[i].Delete();
                                }
                                rbSystemBet.Checked = true;
                                ValuesNUDs();
                                TBsClear();
                                DGVLoad();
                            }
                        }
                        else if (CountEvent <= 16)
                        {
                            rbSystemBet.Checked = true;
                            ValuesNUDs();
                            TBsClear();
                            DGVLoad();
                        }
                    }
                }
                else
                {
                    if (CountEvent > 16)
                    {
                        var resultX = MessageBox.Show(
                       "При режиме \"Система\" максимально возможное\n" +
                       "количество событий в экспрессе - 16!!!\n" +
                       "При переходе в режим \"Система\" события\n" +
                       "с номером больше 16 будут стёрты.\n\nПродолжить?",
                       "BALTBET",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information);
                        if (resultX == DialogResult.Yes)
                        {
                            for (int i = (EventDT.Rows.Count - 1); i >= 0; i--)
                            {
                                if ((Convert.ToInt32(EventDT.Rows[i][0]) == 1) &&
                                    (Convert.ToInt32(EventDT.Rows[i][2]) > 16))
                                    EventDT.Rows[i].Delete();
                            }
                            rbSystemBet.Checked = true;
                            ValuesNUDs();
                            TBsClear();
                            DGVLoad();
                        }
                    }
                    else if (CountEvent <= 16)
                    {
                        rbSystemBet.Checked = true;
                        ValuesNUDs();
                        TBsClear();
                        DGVLoad();
                    }
                }
            }
            
        }
        //

        // Блокировка ввода не цифры
        private void tbPutMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == Convert.ToChar(",") |
                (e.KeyChar == Convert.ToChar(".")) |
                e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;                
        }
        private void tbWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == Convert.ToChar(",") |
                (e.KeyChar == Convert.ToChar(".")) |
                e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;

        }
        private void tbSummBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == Convert.ToChar(",") |
                (e.KeyChar == Convert.ToChar(".")) |
                e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }
        private void tbBetId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }
        private void tbClientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }
        private void tbPrize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == Convert.ToChar(",") |
                (e.KeyChar == Convert.ToChar(".")) |
                e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }
        private void tbSummFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == Convert.ToChar(",") |
                (e.KeyChar == Convert.ToChar(".")) |
                e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }
        private void tbRatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsNumber(e.KeyChar) |
                (e.KeyChar == Convert.ToChar(",") |
                (e.KeyChar == Convert.ToChar(".")) |
                e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }
        //

        // Замена запятой на точку
        private void tbPutMoney_TextChanged(object sender, EventArgs e)
        {
            tbPutMoney.Text = tbPutMoney.Text.Replace(".", "," );
            tbPutMoney.SelectionStart = tbPutMoney.Text.Length;
        }
        private void tbWithdraw_TextChanged(object sender, EventArgs e)
        {
            tbWithdraw.Text = tbWithdraw.Text.Replace(".", ",");
            tbPutMoney.SelectionStart = tbPutMoney.Text.Length;
        }
        private void tbPrize_TextChanged(object sender, EventArgs e)
        {
            tbWithdraw.Text = tbWithdraw.Text.Replace(".", ",");
            tbPutMoney.SelectionStart = tbPutMoney.Text.Length;
        }
        private void tbSummFilter_TextChanged(object sender, EventArgs e)
        {
            tbWithdraw.Text = tbWithdraw.Text.Replace(".", ",");
            tbPutMoney.SelectionStart = tbPutMoney.Text.Length;
        }
        private void tbRatio_TextChanged(object sender, EventArgs e)
        {
            tbWithdraw.Text = tbWithdraw.Text.Replace(".", ",");
            tbPutMoney.SelectionStart = tbPutMoney.Text.Length;
        }
        //

        // Рисование в DGV
        private void DGVBets_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if(isthesamecellvalue(e.ColumnIndex, e.RowIndex))
            {                
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = DGVBets.AdvancedCellBorderStyle.Top;
            }            
        }
        private void DGVBets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (isthesamecellvalue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";                
                e.FormattingApplied = true;
            }
        }
        //
                       
        // Переход в обзор ставок
        private void GeneralTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GeneralTab.SelectedIndex == 1)
            {
                if (dt.Rows.Count > 0)
                {
                    var result = MessageBox.Show(
                        "У Вас есть незавершенные ставки!!!" +
                        "При переходе все данные будут удалены." +
                        "\n\nПродолжить переход???",
                        "BALTBET",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.No)
                    {
                        GeneralTab.SelectedIndex = 0;
                        btnLoadBets.Focus();
                    }                        
                    else
                    {
                        for (int i = (EventDT.Rows.Count - 1); i >= 1; i--)
                        {
                            DeletedEventsAdd(EventDT.Rows[i]);
                        }
                        GeneralPlayer = new Players();
                        LoadTable();
                        DGVLoad();
                        StatusLoad();                        
                    }
                }
                else
                {                    
                    GeneralPlayer = new Players();
                    LoadTable();
                    DGVLoad();
                    StatusLoad();
                }
                Point CSize = new Point(900, 414);                
                MinimumSize = new Size(CSize);
                MaximumSize = new Size(CSize);
                ClientSize = new Size(CSize);
                Text = "Режим просмотра ставок в БАЗЕ ДАННЫХ" + "  -  " + FN;
                CommandsLoad();
                if (chbDateSort.Checked)
                    DateTP.Enabled = true;
                else if(!chbDateSort.Checked)
                    DateTP.Enabled = false;
            }
            else if(GeneralTab.SelectedIndex == 0)
            {
                DGVbetsInDB.DataSource = null;
                TBsFromViewClear();
                LoadBetsTable();
                StatusLoad();
                AttributeBet();
            }
        }

        // Загрузка ставок из БД
        private void btnFind_Click(object sender, EventArgs e)
        {
            DGVfromBetsDB(GetCommand());
            TBsFromViewClear();
        }

        // Доступность и участие в поиске поля Даты
        private void chbDateSort_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDateSort.Checked)
                DateTP.Enabled = true;
            else
                DateTP.Enabled = false;
        }

        // Закрытие формы
        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                var result = MessageBox.Show(
                    "У Вас есть незавершенные ставки!!!" +
                    "\n\nПродолжить выход???",
                    "BALTBET",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    btnLoadBets.Focus();
                }
            }
        }
    }
}



