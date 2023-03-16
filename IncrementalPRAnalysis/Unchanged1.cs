namespace IncrementalPRAnalysis;

public class Unchanged1
{
    // FIXME: S1134 in first unchanged file
}

public class Test
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
