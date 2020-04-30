.PHONY: main.cs

all: main.exe

main.exe: main.cs
	@gmcs main.cs
