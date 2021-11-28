namespace PPE_C_Sharp_BO
{
    public class verifyInput
    {
        public static bool isValidInput(string inputContent)
        {
            return inputContent.Trim(' ') != "" || inputContent.Trim(' ') != " ";
        }
    }
}