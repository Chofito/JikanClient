﻿using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace JikanClient.EnumExtensions
{
    internal static class EnumDescription
    {
        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            if (!(e is Enum)) return string.Empty;

            var type = e.GetType();

                var memInfo = type.GetMember(e.ToString(CultureInfo.InvariantCulture));

                if (memInfo[0]
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() is DescriptionAttribute descriptionAttribute)
                {
                    return descriptionAttribute.Description;
                }

            return string.Empty;
        }
    }
}
