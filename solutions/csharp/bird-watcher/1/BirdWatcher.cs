class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.Exists(birdsPerDay, b => b == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i = 0; i < numberOfDays; i++){
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach(var n in birdsPerDay){
            if (n >= 5) {
                count += 1;
            }
        }

        return count;
    }
}
