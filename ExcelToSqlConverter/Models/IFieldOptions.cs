﻿namespace ExcelToSqlConverter.Models
{
    public interface IFieldOptions
    {
        string Header { get; set; }

        bool Quotes { get; set; }

        OptionsTypeEnum Type { get; }

        ICollection<IFieldOptions> Fields { get; }

        string GetFieldValue(string[] data);
    }
}
