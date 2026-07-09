.PHONY: help install install-api install-client run run-api run-client build clean

help:
	@echo "Targets:"
	@echo "  make install         Install API and client dependencies"
	@echo "  make run             Run API and client together"
	@echo "  make run-api         Run only the .NET API"
	@echo "  make run-client      Run only the React client"
	@echo "  make build           Build API and client for production"
	@echo "  make clean           Remove build artifacts"

install: install-api install-client

install-api:
	cd API && dotnet restore

install-client:
	cd client && npm install

run:
	$(MAKE) -j2 run-api run-client

run-api:
	cd API && dotnet run

run-client:
	cd client && npm start

build:
	cd API && dotnet build
	cd client && npm run build

clean:
	cd API && dotnet clean
	rm -rf client/build
