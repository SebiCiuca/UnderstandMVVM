using System.Reflection;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Utils
{
    public static class EnumExtensions
    {   /// <summary>
        ///     A generic extension method that aids in reflecting 
        ///     and retrieving any attribute that is applied to an `Enum`.
        /// </summary>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
                where TAttribute : Attribute
        {
            var found = enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .FirstOrDefault()
                            .GetCustomAttribute<TAttribute>();

            if (found != null) return found;

            return null;
        }
    }
}
