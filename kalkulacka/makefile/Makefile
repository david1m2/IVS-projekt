.PHONY: UnitTestProject1/UnitTestProject1/mathlibrstest.cs

all: 
	@echo "Supports \"make pack\" and \"make test\"."

pack:
	@zip -r xkotel00_xjanco06_xchyti11_x *

test: UnitTestProject1/UnitTestProject1/mathlibrstest.cs
	@mcs UnitTestProject1/UnitTestProject1/mathlibrstest.cs /reference:UnitTestProject1/UnitTestProject1/bin/Debug/Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll /reference:UnitTestProject1/UnitTestProject1/bin/Debug/matematicka.dll
	./UnitTestProject1/UnitTestProject1/mathlibrstest.exe

