namespace FacadeMethod;

public class HomeAppliances
{
    Tv myTv = new Tv();
    Dvd myDvd = new Dvd();
    Ac myAc = new Ac();


    public void MorningRoutine()
    {
        myAc.TurnOnAc();
        myDvd.TurnOnDvd();
        myTv.TurnOnTV();
    }

    public void MidDayRoutine()
    {
        myAc.IncrementAcTemp();
        myDvd.PlayMovie();
    }

    public void NightRoutine()
    {
        myAc.DecrementAcTemp();
        myTv.TurnOffTV();
        myDvd.TurnOffDvd();
    }
}