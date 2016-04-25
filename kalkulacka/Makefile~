.PHONY: knihovna+testy/UnitTestProject1/UnitTest1.cs

all: 
	@echo "Supports \"make pack\" and \"make test\"."

pack:
	@zip -r xkotel00_xjanco06_xchyti11_xkaras32 *

test: knihovna+testy/UnitTestProject1/UnitTest1.cs
	@mcs knihovna+testy/UnitTestProject1/UnitTest1.cs /reference:knihovna+testy/UnitTestProject1/bin/Debug/Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll /reference:knihovna+testy/UnitTestProject1/bin/Debug/matematicka.dll
	@./knihovna+testy/UnitTestProject1/UnitTest1.exe
