namespace Nancy.ModelBinding
{
    using System;

    /// <summary>
    /// Provides a way to convert from the incoming string representation
    /// of a type to the type itself. Useful for things like datetimes.
    /// </summary>
    public interface ITypeConverter
    {
        /// <summary>
        /// Whether the converter can convert to the destination type
        /// </summary>
        /// <param name="destinationType">Destination type</param>
        /// <returns>True if conversion supported, false otherwise</returns>
        bool CanConvertTo(Type destinationType);

        /// <summary>
        /// Convert the string representation to the destination type
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="destinationType">Destination type</param>
        /// <param name="context">Current context</param>
        /// <returns>Converted object of the destination type</returns>
        object Convert(string input, Type destinationType, NancyContext context);
    }
}