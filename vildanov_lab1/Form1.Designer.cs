using System.Windows.Forms.DataVisualization.Charting;

namespace vildanov_lab1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLaunch = new System.Windows.Forms.Button();
            this.CheckTrajectories = new System.Windows.Forms.CheckBox();
            this.LblTimeStepTracker = new System.Windows.Forms.Label();
            this.EdArea = new System.Windows.Forms.NumericUpDown();
            this.EdWeight = new System.Windows.Forms.NumericUpDown();
            this.LblWeight = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.TrackTimeStep = new System.Windows.Forms.TrackBar();
            this.EdSpeed = new System.Windows.Forms.NumericUpDown();
            this.EdAngle = new System.Windows.Forms.NumericUpDown();
            this.LblAngle = new System.Windows.Forms.Label();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.EdHeight = new System.Windows.Forms.NumericUpDown();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblSpeedAtTheEndPointOutp = new System.Windows.Forms.Label();
            this.LblSpeedAtTheEndPoint = new System.Windows.Forms.Label();
            this.LblTimeStepOutp = new System.Windows.Forms.Label();
            this.LblTimeStep = new System.Windows.Forms.Label();
            this.LblMaxHeightOutp = new System.Windows.Forms.Label();
            this.LblDistanceOutp = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblMaxHeight = new System.Windows.Forms.Label();
            this.LblDistance = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLaunch);
            this.panel1.Controls.Add(this.CheckTrajectories);
            this.panel1.Controls.Add(this.LblTimeStepTracker);
            this.panel1.Controls.Add(this.EdArea);
            this.panel1.Controls.Add(this.EdWeight);
            this.panel1.Controls.Add(this.LblWeight);
            this.panel1.Controls.Add(this.LblArea);
            this.panel1.Controls.Add(this.TrackTimeStep);
            this.panel1.Controls.Add(this.EdSpeed);
            this.panel1.Controls.Add(this.EdAngle);
            this.panel1.Controls.Add(this.LblAngle);
            this.panel1.Controls.Add(this.LblSpeed);
            this.panel1.Controls.Add(this.EdHeight);
            this.panel1.Controls.Add(this.LblHeight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 213);
            this.panel1.TabIndex = 0;
            // 
            // BtnLaunch
            // 
            this.BtnLaunch.Location = new System.Drawing.Point(952, 76);
            this.BtnLaunch.Name = "BtnLaunch";
            this.BtnLaunch.Size = new System.Drawing.Size(141, 46);
            this.BtnLaunch.TabIndex = 1;
            this.BtnLaunch.Text = "Launch";
            this.BtnLaunch.UseVisualStyleBackColor = true;
            this.BtnLaunch.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // CheckTrajectories
            // 
            this.CheckTrajectories.AutoSize = true;
            this.CheckTrajectories.Location = new System.Drawing.Point(722, 90);
            this.CheckTrajectories.Name = "CheckTrajectories";
            this.CheckTrajectories.Size = new System.Drawing.Size(162, 21);
            this.CheckTrajectories.TabIndex = 1;
            this.CheckTrajectories.Text = "CompareTrajectories";
            this.CheckTrajectories.UseVisualStyleBackColor = true;
            // 
            // LblTimeStepTracker
            // 
            this.LblTimeStepTracker.AutoSize = true;
            this.LblTimeStepTracker.Location = new System.Drawing.Point(255, 157);
            this.LblTimeStepTracker.Name = "LblTimeStepTracker";
            this.LblTimeStepTracker.Size = new System.Drawing.Size(117, 17);
            this.LblTimeStepTracker.TabIndex = 8;
            this.LblTimeStepTracker.Text = "TimeStepTracker";
            // 
            // EdArea
            // 
            this.EdArea.DecimalPlaces = 2;
            this.EdArea.Location = new System.Drawing.Point(369, 84);
            this.EdArea.Name = "EdArea";
            this.EdArea.Size = new System.Drawing.Size(120, 22);
            this.EdArea.TabIndex = 4;
            this.EdArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EdWeight
            // 
            this.EdWeight.DecimalPlaces = 2;
            this.EdWeight.Location = new System.Drawing.Point(369, 30);
            this.EdWeight.Name = "EdWeight";
            this.EdWeight.Size = new System.Drawing.Size(120, 22);
            this.EdWeight.TabIndex = 6;
            this.EdWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(293, 30);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(52, 17);
            this.LblWeight.TabIndex = 5;
            this.LblWeight.Text = "Weight";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(293, 89);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(38, 17);
            this.LblArea.TabIndex = 7;
            this.LblArea.Text = "Area";
            // 
            // TrackTimeStep
            // 
            this.TrackTimeStep.LargeChange = 1;
            this.TrackTimeStep.Location = new System.Drawing.Point(369, 152);
            this.TrackTimeStep.Minimum = 1;
            this.TrackTimeStep.Name = "TrackTimeStep";
            this.TrackTimeStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrackTimeStep.Size = new System.Drawing.Size(224, 56);
            this.TrackTimeStep.SmallChange = 10;
            this.TrackTimeStep.TabIndex = 1;
            this.TrackTimeStep.Value = 1;
            // 
            // EdSpeed
            // 
            this.EdSpeed.DecimalPlaces = 2;
            this.EdSpeed.Location = new System.Drawing.Point(103, 152);
            this.EdSpeed.Name = "EdSpeed";
            this.EdSpeed.Size = new System.Drawing.Size(120, 22);
            this.EdSpeed.TabIndex = 2;
            this.EdSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EdAngle
            // 
            this.EdAngle.DecimalPlaces = 2;
            this.EdAngle.Location = new System.Drawing.Point(102, 89);
            this.EdAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.EdAngle.Name = "EdAngle";
            this.EdAngle.Size = new System.Drawing.Size(120, 22);
            this.EdAngle.TabIndex = 3;
            this.EdAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // LblAngle
            // 
            this.LblAngle.AutoSize = true;
            this.LblAngle.Location = new System.Drawing.Point(28, 89);
            this.LblAngle.Name = "LblAngle";
            this.LblAngle.Size = new System.Drawing.Size(44, 17);
            this.LblAngle.TabIndex = 2;
            this.LblAngle.Text = "Angle";
            // 
            // LblSpeed
            // 
            this.LblSpeed.AutoSize = true;
            this.LblSpeed.Location = new System.Drawing.Point(28, 152);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(49, 17);
            this.LblSpeed.TabIndex = 3;
            this.LblSpeed.Text = "Speed";
            // 
            // EdHeight
            // 
            this.EdHeight.DecimalPlaces = 2;
            this.EdHeight.Location = new System.Drawing.Point(102, 30);
            this.EdHeight.Name = "EdHeight";
            this.EdHeight.Size = new System.Drawing.Size(120, 22);
            this.EdHeight.TabIndex = 1;
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(28, 30);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(49, 17);
            this.LblHeight.TabIndex = 1;
            this.LblHeight.Text = "Height";
            // 
            // LblSpeedAtTheEndPointOutp
            // 
            this.LblSpeedAtTheEndPointOutp.AutoSize = true;
            this.LblSpeedAtTheEndPointOutp.Location = new System.Drawing.Point(241, 561);
            this.LblSpeedAtTheEndPointOutp.Name = "LblSpeedAtTheEndPointOutp";
            this.LblSpeedAtTheEndPointOutp.Size = new System.Drawing.Size(0, 17);
            this.LblSpeedAtTheEndPointOutp.TabIndex = 18;
            // 
            // LblSpeedAtTheEndPoint
            // 
            this.LblSpeedAtTheEndPoint.AutoSize = true;
            this.LblSpeedAtTheEndPoint.Location = new System.Drawing.Point(12, 561);
            this.LblSpeedAtTheEndPoint.Name = "LblSpeedAtTheEndPoint";
            this.LblSpeedAtTheEndPoint.Size = new System.Drawing.Size(144, 17);
            this.LblSpeedAtTheEndPoint.TabIndex = 17;
            this.LblSpeedAtTheEndPoint.Text = "SpeedAtTheEndPoint";
            // 
            // LblTimeStepOutp
            // 
            this.LblTimeStepOutp.AutoSize = true;
            this.LblTimeStepOutp.Location = new System.Drawing.Point(239, 428);
            this.LblTimeStepOutp.Name = "LblTimeStepOutp";
            this.LblTimeStepOutp.Size = new System.Drawing.Size(0, 17);
            this.LblTimeStepOutp.TabIndex = 16;
            // 
            // LblTimeStep
            // 
            this.LblTimeStep.AutoSize = true;
            this.LblTimeStep.Location = new System.Drawing.Point(12, 428);
            this.LblTimeStep.Name = "LblTimeStep";
            this.LblTimeStep.Size = new System.Drawing.Size(68, 17);
            this.LblTimeStep.TabIndex = 15;
            this.LblTimeStep.Text = "TimeStep";
            // 
            // LblMaxHeightOutp
            // 
            this.LblMaxHeightOutp.AutoSize = true;
            this.LblMaxHeightOutp.Location = new System.Drawing.Point(239, 521);
            this.LblMaxHeightOutp.Name = "LblMaxHeightOutp";
            this.LblMaxHeightOutp.Size = new System.Drawing.Size(0, 17);
            this.LblMaxHeightOutp.TabIndex = 13;
            // 
            // LblDistanceOutp
            // 
            this.LblDistanceOutp.AutoSize = true;
            this.LblDistanceOutp.Location = new System.Drawing.Point(239, 473);
            this.LblDistanceOutp.Name = "LblDistanceOutp";
            this.LblDistanceOutp.Size = new System.Drawing.Size(0, 17);
            this.LblDistanceOutp.TabIndex = 12;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(75, 376);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(48, 17);
            this.LblResult.TabIndex = 11;
            this.LblResult.Text = "Result";
            // 
            // LblMaxHeight
            // 
            this.LblMaxHeight.AutoSize = true;
            this.LblMaxHeight.Location = new System.Drawing.Point(12, 521);
            this.LblMaxHeight.Name = "LblMaxHeight";
            this.LblMaxHeight.Size = new System.Drawing.Size(97, 17);
            this.LblMaxHeight.TabIndex = 10;
            this.LblMaxHeight.Text = "MaxHeight (Y)";
            // 
            // LblDistance
            // 
            this.LblDistance.AutoSize = true;
            this.LblDistance.Location = new System.Drawing.Point(12, 473);
            this.LblDistance.Name = "LblDistance";
            this.LblDistance.Size = new System.Drawing.Size(83, 17);
            this.LblDistance.TabIndex = 9;
            this.LblDistance.Text = "Distance (x)";
            // 
            // Chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(438, 219);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Trajectory1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Trajectory2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Trajectory3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Trajectory4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Trajectory5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Trajectory6";
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Series.Add(series4);
            this.Chart1.Series.Add(series5);
            this.Chart1.Series.Add(series6);
            this.Chart1.Size = new System.Drawing.Size(844, 600);
            this.Chart1.TabIndex = 1;
            this.Chart1.Text = "Chart";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 831);
            this.Controls.Add(this.LblSpeedAtTheEndPointOutp);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.LblSpeedAtTheEndPoint);
            this.Controls.Add(this.LblTimeStepOutp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTimeStep);
            this.Controls.Add(this.LblDistance);
            this.Controls.Add(this.LblMaxHeightOutp);
            this.Controls.Add(this.LblMaxHeight);
            this.Controls.Add(this.LblDistanceOutp);
            this.Controls.Add(this.LblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar TrackTimeStep;
        private System.Windows.Forms.NumericUpDown EdSpeed;
        private System.Windows.Forms.NumericUpDown EdAngle;
        private System.Windows.Forms.Label LblAngle;
        private System.Windows.Forms.Label LblSpeed;
        private System.Windows.Forms.NumericUpDown EdHeight;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.NumericUpDown EdArea;
        private System.Windows.Forms.NumericUpDown EdWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblTimeStepTracker;
        private System.Windows.Forms.Button BtnLaunch;
        private System.Windows.Forms.CheckBox CheckTrajectories;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LblMaxHeightOutp;
        private System.Windows.Forms.Label LblDistanceOutp;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblMaxHeight;
        private System.Windows.Forms.Label LblDistance;
        private System.Windows.Forms.Label LblTimeStep;
        private System.Windows.Forms.Label LblTimeStepOutp;
        private System.Windows.Forms.Label LblSpeedAtTheEndPoint;
        private System.Windows.Forms.Label LblSpeedAtTheEndPointOutp;
    }
}

