using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridInTextBox
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow:Window
	{
		public MainWindow()
		{
			InitializeComponent();
			CreateDataTable();
			SelectRowsColorChange();
		}

		private void SelectRowsColorChange()
		{
			Style style1 = new Style();
			style1.TargetType = typeof(DataGridCell);

			Style style2 = new Style();
			style2.TargetType = typeof(DataGridRow);

			Trigger triggerIS = new Trigger();
			triggerIS.Property = DataGridCell.IsSelectedProperty;
			triggerIS.Value = true;

			Setter setterF = new Setter();
			setterF.Property = DataGridCell.ForegroundProperty;
			setterF.Value = new SolidColorBrush(Colors.Black);

			Trigger triggerIMO = new Trigger();
			triggerIMO.Property = DataGridRow.IsMouseOverProperty;
			triggerIMO.Value = true;

			Setter setterB = new Setter();
			setterB.Property = DataGridRow.BackgroundProperty;
			setterB.Value = new SolidColorBrush(Colors.Gray);

			triggerIMO.Setters.Add(setterB);
			triggerIS.Setters.Add(setterF);
			style1.Triggers.Add(triggerIS);
			style2.Triggers.Add(triggerIMO);
			dg.CellStyle = style1;
			datagrid.RowStyle = style2;
		}

		private DataTable dgDatatable = new DataTable("Tabledg");

		public DataTable DgDatatable
		{
			get
			{
				return dgDatatable;
			}
			set
			{
				dgDatatable = value;
			}
		}

		private void CreateDataTable()
		{
			#region datagrid内容

			//datagrid内容

			DgDatatable.Columns.Add("科室",typeof(string));
			DgDatatable.Columns.Add("考核项目",typeof(string));
			DgDatatable.Columns.Add("出科人数标准",typeof(int));
			DgDatatable.Columns.Add("出科人数标准得分",typeof(int));
			DgDatatable.Columns.Add("手术费",typeof(decimal));
			DgDatatable.Columns.Add("手术费得分",typeof(int));
			DgDatatable.Columns.Add("科内手术室",typeof(string));
			DgDatatable.Columns.Add("科内手术室得分",typeof(int));
			DgDatatable.Columns.Add("病床使用率",typeof(string));
			DgDatatable.Columns.Add("病床使用率得分",typeof(int));
			DgDatatable.Columns.Add("月业务收入",typeof(decimal));
			DgDatatable.Columns.Add("月业务收入得分",typeof(int));
			DgDatatable.Columns.Add("结余额",typeof(decimal));
			DgDatatable.Columns.Add("结余额得分",typeof(int));
			DgDatatable.Columns.Add("费用成本率",typeof(string));
			DgDatatable.Columns.Add("费用成本率得分",typeof(int));
			DgDatatable.Columns.Add("药品比得分",typeof(int));
			DgDatatable.Columns.Add("累计得分",typeof(int));

			DataRow myDr = DgDatatable.NewRow();
			myDr["科室"] = "儿科";
			myDr["考核项目"] = "bugster切除手术";
			myDr["出科人数标准"] = 4;
			myDr["出科人数标准得分"] = 4;
			myDr["手术费"] = 4396;
			myDr["手术费得分"] = 4;
			myDr["科内手术室"] = "手术室5";
			myDr["科内手术室得分"] = 2;
			myDr["病床使用率"] = "99.9%";
			myDr["病床使用率得分"] = 5;
			myDr["月业务收入"] = 85000;
			myDr["月业务收入得分"] = 5;
			myDr["结余额"] = 85000;
			myDr["结余额得分"] = 8;
			myDr["费用成本率"] = "85%";
			myDr["费用成本率得分"] = 5;
			myDr["药品比得分"] = 7;
			DgDatatable.Rows.Add(myDr);

			DataRow myDr2 = DgDatatable.NewRow();
			myDr2["科室"] = "心脏内科";
			myDr2["考核项目"] = "通波仔";
			myDr2["出科人数标准"] = 10;
			myDr2["出科人数标准得分"] = 5;
			myDr2["手术费"] = 25764;
			myDr2["手术费得分"] = 5;
			myDr2["科内手术室"] = "手术室6";
			myDr2["科内手术室得分"] = 3;
			myDr2["病床使用率"] = "99.9%";
			myDr2["病床使用率得分"] = 4;
			myDr2["月业务收入"] = 200000;
			myDr2["月业务收入得分"] = 8;
			myDr2["结余额"] = 78554;
			myDr2["结余额得分"] = 6;
			myDr2["费用成本率"] = "85%";
			myDr2["费用成本率得分"] = 8;
			myDr2["药品比得分"] = 6;
			DgDatatable.Rows.Add(myDr2);

			DataRow myDr3 = DgDatatable.NewRow();
			myDr3["科室"] = "内科";
			myDr3["考核项目"] = "伤风";
			myDr3["出科人数标准"] = 10;
			myDr3["出科人数标准得分"] = 5;
			myDr3["手术费"] = 75372;
			myDr3["手术费得分"] = 5;
			myDr3["科内手术室"] = "手术室9";
			myDr3["科内手术室得分"] = 3;
			myDr3["病床使用率"] = "99.9%";
			myDr3["病床使用率得分"] = 4;
			myDr3["月业务收入"] = 7535273;
			myDr3["月业务收入得分"] = 4;
			myDr3["结余额"] = 2453;
			myDr3["结余额得分"] = 4;
			myDr3["费用成本率"] = "85%";
			myDr3["费用成本率得分"] = 4;
			myDr3["药品比得分"] = 10;
			DgDatatable.Rows.Add(myDr3);

			DataRow myDr4 = DgDatatable.NewRow();
			myDr4["科室"] = "外科";
			myDr4["考核项目"] = "骨折";
			myDr4["出科人数标准"] = 10;
			myDr4["出科人数标准得分"] = 1;
			myDr4["手术费"] = 78575;
			myDr4["手术费得分"] = 2;
			myDr4["科内手术室"] = "手术室66";
			myDr4["科内手术室得分"] = 3;
			myDr4["病床使用率"] = "99.9%";
			myDr4["病床使用率得分"] = 5;
			myDr4["月业务收入"] = 4534452;
			myDr4["月业务收入得分"] = 8;
			myDr4["结余额"] = 78676;
			myDr4["结余额得分"] = 9;
			myDr4["费用成本率"] = "85%";
			myDr4["费用成本率得分"] = 4;
			myDr4["药品比得分"] = 8;
			DgDatatable.Rows.Add(myDr4);

			DataRow myDr5 = DgDatatable.NewRow();
			myDr5["科室"] = "神经内科";
			myDr5["考核项目"] = "老人痴呆";
			myDr5["出科人数标准"] = 10;
			myDr5["出科人数标准得分"] = 5;
			myDr5["手术费"] = 78572;
			myDr5["手术费得分"] = 5;
			myDr5["科内手术室"] = "手术室9";
			myDr5["科内手术室得分"] = 3;
			myDr5["病床使用率"] = "99.9%";
			myDr5["病床使用率得分"] = 4;
			myDr5["月业务收入"] = 78567;
			myDr5["月业务收入得分"] = 4;
			myDr5["结余额"] = 445;
			myDr5["结余额得分"] = 4;
			myDr5["费用成本率"] = "85%";
			myDr5["费用成本率得分"] = 4;
			myDr5["药品比得分"] = 1;
			DgDatatable.Rows.Add(myDr5);

			DataRow myDr6 = DgDatatable.NewRow();
			myDr6["科室"] = "内科";
			myDr6["考核项目"] = "发热";
			myDr6["出科人数标准"] = 10;
			myDr6["出科人数标准得分"] = 5;
			myDr6["手术费"] = 25764;
			myDr6["手术费得分"] = 5;
			myDr6["科内手术室"] = "手术室9";
			myDr6["科内手术室得分"] = 3;
			myDr6["病床使用率"] = "99.9%";
			myDr6["病床使用率得分"] = 4;
			myDr6["月业务收入"] = 200000;
			myDr6["月业务收入得分"] = 4;
			myDr6["结余额"] = 78554;
			myDr6["结余额得分"] = 8;
			myDr6["费用成本率"] = "85%";
			myDr6["费用成本率得分"] = 8;
			myDr6["药品比得分"] = 8;
			DgDatatable.Rows.Add(myDr6);

			DataRow myDr7 = DgDatatable.NewRow();
			myDr7["科室"] = "传染科";
			myDr7["考核项目"] = "H5N1";
			myDr7["出科人数标准"] = 10;
			myDr7["出科人数标准得分"] = 5;
			myDr7["手术费"] = 4356;
			myDr7["手术费得分"] = 5;
			myDr7["科内手术室"] = "手术室9";
			myDr7["科内手术室得分"] = 3;
			myDr7["病床使用率"] = "99.9%";
			myDr7["病床使用率得分"] = 4;
			myDr7["月业务收入"] = 235;
			myDr7["月业务收入得分"] = 4;
			myDr7["结余额"] = 456;
			myDr7["结余额得分"] = 7;
			myDr7["费用成本率"] = "85%";
			myDr7["费用成本率得分"] = 4;
			myDr7["药品比得分"] = 7;
			DgDatatable.Rows.Add(myDr7);

			DataRow myDr8 = DgDatatable.NewRow();
			myDr8["科室"] = "妇科";
			myDr8["考核项目"] = "分娩";
			myDr8["出科人数标准"] = 10;
			myDr8["出科人数标准得分"] = 2;
			myDr8["手术费"] = 123;
			myDr8["手术费得分"] = 5;
			myDr8["科内手术室"] = "手术室9";
			myDr8["科内手术室得分"] = 3;
			myDr8["病床使用率"] = "99.9%";
			myDr8["病床使用率得分"] = 4;
			myDr8["月业务收入"] = 456;
			myDr8["月业务收入得分"] = 4;
			myDr8["结余额"] = 789;
			myDr8["结余额得分"] = 8;
			myDr8["费用成本率"] = "85%";
			myDr8["费用成本率得分"] = 4;
			myDr8["药品比得分"] = 2;
			DgDatatable.Rows.Add(myDr8);

			DataRow myDr9 = DgDatatable.NewRow();
			myDr9["科室"] = "儿科";
			myDr9["考核项目"] = "先天性缺陷";
			myDr9["出科人数标准"] = 10;
			myDr9["出科人数标准得分"] = 5;
			myDr9["手术费"] = 15689;
			myDr9["手术费得分"] = 5;
			myDr9["科内手术室"] = "手术室9";
			myDr9["科内手术室得分"] = 3;
			myDr9["病床使用率"] = "99.9%";
			myDr9["病床使用率得分"] = 4;
			myDr9["月业务收入"] = 46489;
			myDr9["月业务收入得分"] = 5;
			myDr9["结余额"] = 16548;
			myDr9["结余额得分"] = 5;
			myDr9["费用成本率"] = "85%";
			myDr9["费用成本率得分"] = 5;
			myDr9["药品比得分"] = 0;
			DgDatatable.Rows.Add(myDr9);

			DataRow myDr10 = DgDatatable.NewRow();
			myDr10["科室"] = "CR";
			myDr10["考核项目"] = "手术等级LV100";
			myDr10["出科人数标准"] = 1;
			myDr10["出科人数标准得分"] = 5;
			myDr10["手术费"] = 0;
			myDr10["手术费得分"] = 5;
			myDr10["科内手术室"] = "手术室9";
			myDr10["科内手术室得分"] = 5;
			myDr10["病床使用率"] = "99.9%";
			myDr10["病床使用率得分"] = 5;
			myDr10["月业务收入"] = 0;
			myDr10["月业务收入得分"] = 5;
			myDr10["结余额"] = 0;
			myDr10["结余额得分"] = 5;
			myDr10["费用成本率"] = "85%";
			myDr10["费用成本率得分"] = 10;
			myDr10["药品比得分"] = 10;
			DgDatatable.Rows.Add(myDr10);

			DataRow myDr11 = DgDatatable.NewRow();
			myDr11["科室"] = "无证";
			myDr11["考核项目"] = "第50战术";
			myDr11["出科人数标准"] = 10;
			myDr11["出科人数标准得分"] = 5;
			myDr11["手术费"] = 25764;
			myDr11["手术费得分"] = 5;
			myDr11["科内手术室"] = "手术室9";
			myDr11["科内手术室得分"] = 3;
			myDr11["病床使用率"] = "99.9%";
			myDr11["病床使用率得分"] = 4;
			myDr11["月业务收入"] = 200000;
			myDr11["月业务收入得分"] = 10;
			myDr11["结余额"] = 78554;
			myDr11["结余额得分"] = 10;
			myDr11["费用成本率"] = "85%";
			myDr11["费用成本率得分"] = 10;
			myDr11["药品比得分"] = 10;
			DgDatatable.Rows.Add(myDr11);

			#endregion datagrid内容

			dg.ItemsSource = DgDatatable.DefaultView;

			DataTable dt = DgDatatable.Clone();

			dt.Clear();

			datagrid.ItemsSource = dt.DefaultView;
		}

		private void textbox_PreviewMouseLeftButtonDown(object sender,MouseButtonEventArgs e)
		{
			if(popup.IsOpen)
			{
				popup.IsOpen = false;
				popup.StaysOpen = false;
			}
			else
			{
				popup.IsOpen = true;
				popup.StaysOpen = true;
				dg.UpdateLayout();
			}
		}

		private void MouseLeaveOrEnter(object sender,MouseEventArgs e)
		{
			popup.IsOpen = false;
			popup.StaysOpen = false;
		}

		private void dg_MouseDoubleClick(object sender,MouseButtonEventArgs e)
		{
			DataGrid Clickdg = sender as DataGrid;

			if(Clickdg.SelectedItem != null)
			{
				DataRow dr = (Clickdg.SelectedItem as DataRowView).Row;
				DataTable dt = (datagrid.ItemsSource as DataView).ToTable();
				dt.Rows.Add(dr.ItemArray);
				datagrid.ItemsSource = dt.DefaultView;
			}
		}

		private void textbox_TextChanged(object sender,TextChangedEventArgs e)
		{
			TextBox textbox = sender as TextBox;
			string text = textbox.Text.Trim();
			popup.IsOpen = true;
			popup.StaysOpen = true;

			if(text != null && text != "")
			{
				for(int i = 0;i < dg.ItemContainerGenerator.Items.Count;i++)
				{
					DataGridRow dgv = (DataGridRow)dg.ItemContainerGenerator.ContainerFromIndex(i);
					if(dgv == null)
					{
						dg.UpdateLayout();
						dg.ScrollIntoView(dg.Items[i]);
						dgv = (DataGridRow)dg.ItemContainerGenerator.ContainerFromIndex(i);
					}
					bool showdgv = false;
					DataRow dr = (dgv.Item as DataRowView).Row;
					for(int j = 0;j < dr.ItemArray.Length;j++)
					{
						dgv.UpdateLayout();
						DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(dgv);
						DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(j);
						string cellcontent = dr[j].ToString().Trim();
						if(cellcontent.ToLower().Contains(text.ToLower()))
						{
							cell.Background = new SolidColorBrush(Colors.Orange);
							showdgv = true;
						}
						else
						{
							cell.Background = null;
						}
					}
					if(showdgv)
					{
						dgv.Visibility = Visibility.Visible;
					}
					else
					{
						dgv.Visibility = Visibility.Collapsed;
					}
				}
			}
			else
			{
				for(int i = 0;i < dg.ItemContainerGenerator.Items.Count;i++)
				{
					DataGridRow dgv = (DataGridRow)dg.ItemContainerGenerator.ContainerFromIndex(i);
					if(dgv == null)
					{
						dg.UpdateLayout();
						dg.ScrollIntoView(dg.Items[i]);
						dgv = (DataGridRow)dg.ItemContainerGenerator.ContainerFromIndex(i);
					}
					dgv.Visibility = Visibility.Visible;
					DataRow dr = (dgv.Item as DataRowView).Row;
					for(int j = 0;j < dr.ItemArray.Length;j++)
					{
						dgv.UpdateLayout();
						DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(dgv);
						DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(j);
						cell.Background = null;
					}
				}
			}
		}

		/// <summary>
		/// 获取父可视对象中第一个指定类型的子可视对象
		/// </summary>
		/// <typeparam name="T">可视对象类型</typeparam>
		/// <param name="parent">父可视对象</param>
		/// <returns>第一个指定类型的子可视对象</returns>
		public static T GetVisualChild<T>(Visual parent) where T : Visual
		{
			T child = default(T);
			int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
			for(int i = 0;i < numVisuals;i++)
			{
				Visual v = (Visual)VisualTreeHelper.GetChild(parent,i);
				child = v as T;
				if(child == null)
				{
					child = GetVisualChild<T>(v);
				}
				if(child != null)
				{
					break;
				}
			}
			return child;
		}
	}

	#region 依赖属性判断
	//public static class DataGridTextSearch
	//{
	//	// Using a DependencyProperty as the backing store for SearchValue.  This enables animation, styling, binding, etc...
	//	public static readonly DependencyProperty SearchValueProperty =
	//		DependencyProperty.RegisterAttached("SearchValue",typeof(string),typeof(DataGridTextSearch),
	//			new FrameworkPropertyMetadata(string.Empty,FrameworkPropertyMetadataOptions.Inherits));

	//	public static string GetSearchValue(DependencyObject obj)
	//	{
	//		return (string)obj.GetValue(SearchValueProperty);
	//	}

	//	public static void SetSearchValue(DependencyObject obj,string value)
	//	{
	//		obj.SetValue(SearchValueProperty,value);
	//	}

	//	// Using a DependencyProperty as the backing store for IsTextMatch.  This enables animation, styling, binding, etc...
	//	public static readonly DependencyProperty IsTextMatchProperty =
	//		DependencyProperty.RegisterAttached("IsTextMatch",typeof(bool),typeof(DataGridTextSearch),new UIPropertyMetadata(false));

	//	public static bool GetIsTextMatch(DependencyObject obj)
	//	{
	//		return (bool)obj.GetValue(IsTextMatchProperty);
	//	}

	//	public static void SetIsTextMatch(DependencyObject obj,bool value)
	//	{
	//		obj.SetValue(IsTextMatchProperty,value);
	//	}
	//}

	//public class SearchValueConverter:IMultiValueConverter
	//{
	//	public object Convert(object[] values,Type targetType,object parameter,System.Globalization.CultureInfo culture)
	//	{
	//		string cellText = values[0] == null ? string.Empty : values[0].ToString();
	//		string searchText = values[1] as string;

	//		if(!string.IsNullOrEmpty(searchText) && !string.IsNullOrEmpty(cellText))
	//		{
	//			return cellText.ToLower().StartsWith(searchText.ToLower());
	//		}
	//		return false;
	//	}

	//	public object[] ConvertBack(object value,Type[] targetTypes,object parameter,System.Globalization.CultureInfo culture)
	//	{
	//		return null;
	//	}
	//}
	#endregion
}
