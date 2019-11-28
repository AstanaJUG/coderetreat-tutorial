package kz.coderetreat;

import org.junit.Test;

public class AppTest 
{
    @Test
    public void sumShouldReturnCorrectSumOfTwoInts() {
        assert App.sum(1,2) == 3;
    }
}
