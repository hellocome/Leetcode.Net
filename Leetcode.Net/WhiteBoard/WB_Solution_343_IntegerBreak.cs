    public int IntegerBreak(int n) {
		long result = 1;
		
		if(n == 2)
		{
			return 1;
		}
		else if(n == 3)
		{
			return 2;
		}
		
		while(n > 4 && result <= Int32.Maximum)
		{
			n = n - 3;
			result = res * 3;
		}
		
		if( n == 4)
		{
			result = result * 4;
		}
		else if( n == 3 )
		{
			result = result * 3;
		}
		else if( n == 2 )
		{
			result = result * 2;
		}
		
		if(result > Int32.Maximum)
		{
			return 0;
		}
		else
		{
			return result;
		}
    }