namespace NumericalIntegration_program
{
    internal interface INtegrationMethodClass
    {
        double TrapezodalMethod(int numberOfInterval);

        double SimpsonMethod(int numberOfInterval);
    }
}