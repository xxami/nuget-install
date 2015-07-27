
# make me !
#
# pre-requires:
# sudo apt-get install mono mono-devel mono-complete
# nuget command-line must be installed/available on path (tests only)
#
# install test depends:
#   make test-depends
#
# build result and tests:
#   make
#
# run the tests:
#   make test

## configure

csc=mcs
bin=./nuget-install

## depends: reference assemblies/tools

# tests only
nunit_console_bin=nunit-console.exe
nunit_console_path=depends/NUnit.Runners.2.6.4/tools
nunit_framework_asm=nunit.framework.dll
nunit_framework_path=depends/NUnit.Runners.2.6.4/tools

# references
test_refs=\
	/r:$(nunit_framework_asm)\

## source files

# compilation units
cs_units=\
	classes/NuGetInstall.cs\

## build system

# make
all: $(bin)

$(bin): $(cs_units)
	$(csc) $(cs_units) /out:$(bin) /t:exe

# make test-depends
test-depends:
	nuget install nunit.runners -version 2.6.4 -o depends
	chmod +x $(nunit_console_path)/$(nunit_console_bin)	
