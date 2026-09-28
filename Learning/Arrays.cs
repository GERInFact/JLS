using System.Diagnostics;

namespace Learning;

public static class Arrays
{
    public static void JaggedArray()
    {
        const int COLUMN_COUNT = 5;
        const int ROW_COUNT = 4;

        var downloadProgresses = new int[ROW_COUNT][];

        downloadProgresses[0] = new int[10_000_000];
        downloadProgresses[1] = new[] { 1, 2, 3, 4 };
        downloadProgresses[2] = new[] { 10, 23 };
        downloadProgresses[3] = new[] { -2, 3, 5, 12, 67 };

        for (var i = 0; i < ROW_COUNT; i++)
        {
            var currentColumnCount = downloadProgresses[i].GetLength(0);
            for (var j = 0; j < currentColumnCount; j++)
                Console.WriteLine(downloadProgresses[i][j]);
        }
        
    }
}