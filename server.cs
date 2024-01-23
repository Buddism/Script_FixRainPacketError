//create a new datablock thats not id 3
datablock StaticShapeData (dummyPlayer2 : dummyPlayer)
{
	shapeFile = "base/data/shapes/player/m.dts";
};

//replace datablockgroup #0 to our new db
//as new rains use first object in datablockgroup
datablockGroup.bringToFront(dummyPlayer2);

//alternative fix to this is to package the rain creation code to use a different db