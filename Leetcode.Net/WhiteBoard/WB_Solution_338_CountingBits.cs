    public int[] CountBits(int num) {
        
		List<int> result = new List<int>();
		
		result.Add(0);
		
		for(int i=1; i<=num; i++)
		{
			int count = 0;
			int calNum = i;
			// Max is 8
			while(calNum > 0)
			{
				if( (calNum & 1) == 1)
				{
					count++;
				}
				
				calNum = calNum >> 1;	
			}
			
			result.Add(count);
		}
		
		return result.ToArray();
    }