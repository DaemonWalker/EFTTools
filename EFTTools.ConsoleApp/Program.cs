// See https://aka.ms/new-console-template for more information
using EFTTools.Common;


var data = new EFTData();
data.GetItemInfo("5448bd6b4bdc2dfc2f8b4569", out var item);

var json = item.JsonElement.GetItemProps();
Console.WriteLine(json);

Console.WriteLine(json.Get("Width"));
