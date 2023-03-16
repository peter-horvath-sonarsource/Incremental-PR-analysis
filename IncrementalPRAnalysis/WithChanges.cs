namespace IncrementalPRAnalysis;

public class WithChanges
{
    private void UnusedMethod()
    {
    }

    public int AnotherUnusedMethod(bool a, bool b)
    {
        string unusedVar = null;

        if (a)
        {
            if (b)
            {
                return 0;
            }
        }

        return 1;
    }
}
