using AstroCalculations;

AstroCalc astro = new AstroCalc();

//velocity
double vel;
vel = astro.StarVelocity(500.1, 500);
Console.WriteLine(vel);

//distance
double dist;
dist = astro.StarDistance(0.547);
Console.WriteLine(dist);

//kelvin testing
double  kelRes;
kelRes = astro.TempKelvin(27);
Console.WriteLine(kelRes);

//horizion
double bro;
bro = astro.EventHorizon(8.1*Math.Pow(10,36));
Console.WriteLine(bro);




