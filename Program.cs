// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Garage;
            
Zero fxs = new Zero
{
    MainColor = "Blue"
};
Tesla modelS = new Tesla
{
    MainColor = "Black"
};
Cessna mx410 = new Cessna
{
    MainColor = "Blue"
};
Ram rampage = new Ram
{
    MainColor = "Green"
};


fxs.Drive();
fxs.Turn("left");
fxs.Stop();

modelS.Drive();
modelS.Turn("left");
modelS.Stop();

mx410.Drive();
mx410.Turn("left");
mx410.Stop();

rampage.Drive();
rampage.Turn("right");
rampage.Stop();