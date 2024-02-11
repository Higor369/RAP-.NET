using RobotBlaze;

var service = new BlazeService();

var blaze = await service.GetBlazes();

var palpite = await BlazeGPT.GetPalpite(blaze);

Console.WriteLine(palpite);