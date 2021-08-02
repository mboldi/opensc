﻿using OpenSC.Model;
using OpenSC.Model.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OpenSC.GUI.GeneralComponents.Tables
{
    public class CustomDataGridViewRow<T>: DataGridViewRow
    {

        CustomDataGridView<T> table;

        List<DataGridViewCell> cells = new List<DataGridViewCell>();

        T item;

        public CustomDataGridViewRow(CustomDataGridView<T> table, T item)
        {
            if ((table == null) || (item == null))
                throw new ArgumentNullException();
            this.table = table;
            this.item = item;
            createCells();
            subscribeToItemEvents();
            subscribeToMultilevelItemEvents();
            subscribeToExternalUpdateEvents();
        }

        private void createCells()
        {
            foreach (CustomDataGridViewColumnDescriptor<T> columnDescriptor in table.ColumnDescriptors)
            {
                DataGridViewCell cell = createAndInitCell(columnDescriptor);
                cells.Add(cell);
            }
        }

        private void subscribeToItemEvents()
        {
            INotifyPropertyChanged itemCastedINotifyPropertyChanged = item as INotifyPropertyChanged;
            if (itemCastedINotifyPropertyChanged != null)
                itemCastedINotifyPropertyChanged.PropertyChanged += notifyPropertyChangedHandler;
        }

        private void subscribeToMultilevelItemEvents()
        {
            INotifyPropertyChanged itemCastedINotifyPropertyChanged = item as INotifyPropertyChanged;
            if (itemCastedINotifyPropertyChanged == null)
                return;
            for (int i = 0; i < cells.Count; i++)
            {
                DataGridViewCell cell = cells[i];
                CustomDataGridViewColumnDescriptor<T> columnDescriptor = table.ColumnDescriptors[i];
                foreach (string[] eventNames in columnDescriptor.MultilevelChangeEvents)
                {
                    object[] tagData = new object[] { cell, columnDescriptor };
                    MultilevelPropertyChangeObserver multilevelObserver = new MultilevelPropertyChangeObserver(itemCastedINotifyPropertyChanged, eventNames, tagData);
                    multilevelObserver.MultilevelPropertyChanged += notifyMultilevelPropertyChangedHandler;
                }
            }
        }

        private void subscribeToExternalUpdateEvents()
        {
            for (int i = 0; i < cells.Count; i++)
            {
                DataGridViewCell cell = cells[i];
                CustomDataGridViewColumnDescriptor<T> columnDescriptor = table.ColumnDescriptors[i];
                columnDescriptor.ExternalUpdateEventSubscriberMethod?.Invoke(item, () => columnDescriptor.UpdaterMethod?.Invoke(item, cell));
            }
        }

        private void notifyPropertyChangedHandler(string propertyName)
        {
            int column = 0;
            foreach (CustomDataGridViewColumnDescriptor<T> columnDescriptor in table.ColumnDescriptors)
            {
                if (columnDescriptor.ChangeEvents.Contains(propertyName))
                    columnDescriptor.UpdaterMethod?.Invoke(item, cells[column]);
                column++;
            }
        }

        private void notifyMultilevelPropertyChangedHandler(string fullPropertyName, MultilevelPropertyChangeObserver observer)
        {
            object[] tagData = observer.Tag as object[];
            if ((tagData == null) || (tagData.Length != 2))
                return;
            DataGridViewCell cell = tagData[0] as DataGridViewCell;
            CustomDataGridViewColumnDescriptor<T> columnDescriptor = tagData[1] as CustomDataGridViewColumnDescriptor<T>;
            if (cell == null)
                return;
            columnDescriptor.UpdaterMethod?.Invoke(item, cell);
        }

        private DataGridViewCell createAndInitCell(CustomDataGridViewColumnDescriptor<T> columnDescriptor)
        {

            DataGridViewCell cell = getCellByType(columnDescriptor.Type);

            if (columnDescriptor.Type == DataGridViewColumnType.CheckBox)
            {
                DataGridViewCheckBoxCell typedCell = (DataGridViewCheckBoxCell)cell;
                typedCell.FalseValue = false;
                typedCell.TrueValue = true;
            }

            if(columnDescriptor.Type == DataGridViewColumnType.Image)
            {
                DataGridViewImageCell typedCell = (DataGridViewImageCell)cell;
                typedCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                typedCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (columnDescriptor.Type == DataGridViewColumnType.ImageButton)
            {
                DataGridViewImageButtonCell typedCell = (DataGridViewImageButtonCell)cell;
                typedCell.Image = columnDescriptor.ButtonImage;
                typedCell.ImagePadding = columnDescriptor.ButtonImagePadding;
            }

            if (columnDescriptor.Type == DataGridViewColumnType.SmallIcon)
            {
                DataGridViewSmallIconCell typedCell = (DataGridViewSmallIconCell)cell;
                typedCell.IconShown = columnDescriptor.IconShown;
                typedCell.IconColor = columnDescriptor.IconColor;
                typedCell.IconType = columnDescriptor.IconType;
                typedCell.IconPadding = columnDescriptor.IconPadding;
            }

            if (columnDescriptor.Type == DataGridViewColumnType.Button)
            {
                cell.Value = columnDescriptor.ButtonText;
            }

            if (columnDescriptor.Type == DataGridViewColumnType.DisableButton)
            {
                cell.Value = columnDescriptor.ButtonText;
            }

            if (columnDescriptor.Type == DataGridViewColumnType.ComboBox)
            {
                DataGridViewComboBoxCell typedCell = (DataGridViewComboBoxCell)cell;
                typedCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                typedCell.ValueMember = "Value";
                typedCell.DisplayMember = "Label";
                typedCell.Items.AddRange(columnDescriptor.DropDownPopulatorMethod?.Invoke(item, cell));
            }

            Cells.Add(cell);

            if (columnDescriptor.Type == DataGridViewColumnType.TextBox)
            {
                cell.ReadOnly = !columnDescriptor.TextEditable;
            }

            if (columnDescriptor.Type == DataGridViewColumnType.SmallIcon)
            {
                cell.ReadOnly = true;
            }

            columnDescriptor.InitializerMethod?.Invoke(item, cell);
            columnDescriptor.UpdaterMethod?.Invoke(item, cell);

            return cell;

        }

        private void updateCell(int columnIndex)
        {
            getColumnDescriptor(columnIndex).UpdaterMethod?.Invoke(item, Cells[columnIndex]);
        }

        private static DataGridViewCell getCellByType(DataGridViewColumnType type)
        {
            switch (type)
            {
                case DataGridViewColumnType.TextBox:
                    return new DataGridViewTextBoxCell();
                case DataGridViewColumnType.CheckBox:
                    return new DataGridViewCheckBoxCell();
                case DataGridViewColumnType.Image:
                    return new DataGridViewImageCell();
                case DataGridViewColumnType.Button:
                    return new DataGridViewButtonCell();
                case DataGridViewColumnType.ComboBox:
                    return new DataGridViewComboBoxCell();
                case DataGridViewColumnType.Link:
                    return new DataGridViewLinkCell();
                case DataGridViewColumnType.DisableButton:
                    return new DataGridViewDisableButtonCell();
                case DataGridViewColumnType.ImageButton:
                    return new DataGridViewImageButtonCell();
                case DataGridViewColumnType.SmallIcon:
                    return new DataGridViewSmallIconCell();
            }
            return null;
        }

        public void HandleContentClick(DataGridViewCellEventArgs eventArgs)
        {
            int ci = eventArgs.ColumnIndex;
            getColumnDescriptor(ci).ContentClickHandlerMethod?.Invoke(item, Cells[ci], eventArgs);
        }

        public void HandleDoubleClick(DataGridViewCellEventArgs eventArgs)
        {
            int ci = eventArgs.ColumnIndex;
            getColumnDescriptor(ci).DoubleClickHandlerMethod?.Invoke(item, Cells[ci], eventArgs);
        }

        public void HandleEndEdit(DataGridViewCellEventArgs eventArgs)
        {
            int ci = eventArgs.ColumnIndex;
            getColumnDescriptor(ci).EndEditHandlerMethod?.Invoke(item, Cells[ci], eventArgs);
        }

        private CustomDataGridViewColumnDescriptor<T> getColumnDescriptor(int columnIndex)
        {
            return table.ColumnDescriptors[columnIndex];
        }

    }
}