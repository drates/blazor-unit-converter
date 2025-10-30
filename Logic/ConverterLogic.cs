namespace BlazorConverter.Logic
{
    public static class ConverterLogic
    {
        // Converts inches to meters
        public static double ConvertLength(double inputInches)
        {
            return inputInches * 0.0254;
        }

        // Converts Fahrenheit to Celsius
        public static double ConvertTemp(double inputF)
        {
            // (F - 32) * (5/9)
            return (inputF - 32.00) * (5.00 / 9.00);
        }
    }
}