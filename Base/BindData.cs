using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Base
{
    public static class BindData<T> where T : class
    {       /// <summary>
            /// Binding of data
            /// </summary>
            /// <param name="dataSource">Data source to bind from</param>
            /// <param name="webControl">Control to bind data</param>
            /// <param name="title">Default value of list(if list type control is passed)</param>
        public static void Bind(Control webControl, IEnumerable<T> listDataSource = null, string dataTextField = null, string dataValueField = null, string title = null, DataTable dataTableDataSource = null)
        {
            try
            {
                if (listDataSource != null || dataTableDataSource != null)
                {
                    if (webControl is GridView)
                    {
                        GridView gridView = (GridView)webControl;
                        if (listDataSource != null)
                            gridView.DataSource = listDataSource;
                        else
                            gridView.DataSource = dataTableDataSource;
                        gridView.DataBind();
                    }
                    else if (webControl is DropDownList)
                    {
                        DropDownList dropDownList = (DropDownList)webControl;
                        dropDownList.Items.Clear();
                        if (listDataSource != null)
                            dropDownList.DataSource = listDataSource;
                        else
                            dropDownList.DataSource = dataTableDataSource;
                        dropDownList.DataValueField = !string.IsNullOrWhiteSpace(dataValueField) ? dataValueField : "ID";
                        dropDownList.DataTextField = !string.IsNullOrWhiteSpace(dataTextField) ? dataTextField : "Title";
                        dropDownList.DataBind();
                        title = string.IsNullOrWhiteSpace(title) ? "--Select--" : title;
                        dropDownList.Items.Insert(0, new ListItem(title, "0"));
                    }
                    else if (webControl is RadioButtonList)
                    {
                        RadioButtonList radioButtonList = (RadioButtonList)webControl;
                        radioButtonList.Items.Clear();
                        if (listDataSource != null)
                            radioButtonList.DataSource = listDataSource;
                        else
                            radioButtonList.DataSource = dataTableDataSource;
                        radioButtonList.DataValueField = !string.IsNullOrWhiteSpace(dataValueField) ? dataValueField : "ID";
                        radioButtonList.DataTextField = !string.IsNullOrWhiteSpace(dataTextField) ? dataTextField : "Title";
                        radioButtonList.DataBind();
                    }
                    else if (webControl is ListBox)
                    {
                        ListBox listBox = (ListBox)webControl;
                        listBox.Items.Clear();
                        if (listDataSource != null)
                            listBox.DataSource = listDataSource;
                        else
                            listBox.DataSource = dataTableDataSource;
                        listBox.DataValueField = !string.IsNullOrWhiteSpace(dataValueField) ? dataValueField : "ID";
                        listBox.DataTextField = !string.IsNullOrWhiteSpace(dataTextField) ? dataTextField : "Title";
                        listBox.DataBind();
                    }
                    else if (webControl is CheckBoxList)
                    {
                        CheckBoxList checkBoxList = (CheckBoxList)webControl;
                        checkBoxList.Items.Clear();
                        if (listDataSource != null)
                            checkBoxList.DataSource = listDataSource;
                        else
                            checkBoxList.DataSource = dataTableDataSource;
                        checkBoxList.DataValueField = !string.IsNullOrWhiteSpace(dataValueField) ? dataValueField : "ID";
                        checkBoxList.DataTextField = !string.IsNullOrWhiteSpace(dataTextField) ? dataTextField : "Title";
                        checkBoxList.DataBind();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
