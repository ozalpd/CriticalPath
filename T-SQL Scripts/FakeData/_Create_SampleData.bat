@echo .
@echo .
@echo 1 - Executing _Identity-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i _Identity-Data.sql

@echo .
@echo .
@echo 2 - Executing EmployeePosition-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i EmployeePosition-Data.sql

@echo .
@echo .
@echo 3 - Executing Employees.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Employees.Data.sql

@echo .
@echo .
@echo 4 - Executing FreightTerms.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i FreightTerms.Data.sql

@echo .
@echo .
@echo 5 - Executing Currencies.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Currencies.Data.sql

@echo .
@echo .
@echo 6 - Executing Country-data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Country-data.sql

@echo .
@echo .
@echo 7 - Executing SizingStandards.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i SizingStandards.Data.sql

@echo .
@echo .
@echo 8 - Executing Sizings.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Sizings.Data.sql

@echo .
@echo .
@echo 9 - Executing Company.sql... Contact-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Contact-Data.sql

@echo .
@echo .
@echo 10 - Executing Customer.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Customer.Data.sql

@echo .
@echo .
@echo 11 - Executing Supplier.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Supplier.Data.sql

@echo .
@echo .
@echo 12 - Executing Manufacturer.Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Manufacturer.Data.sql

@echo .
@echo .
@echo 13 - Executing ProductCategory-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i ProductCategory-Data.sql

@echo .
@echo .
@echo 14 - Executing Product-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Product-Data.sql

@echo .
@echo .
@echo 15 - Executing PurchaseOrder-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i PurchaseOrder-Data.sql

@echo .
@echo .
@echo 16 - Executing ProcessTemplate-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i ProcessTemplate-Data.sql

@echo .
@echo .
@echo 17 - Executing Process-Data.sql...
@sqlcmd -S .\SqlExpress -d CriticalPath -E -i Process-Data.sql


@echo .
@echo * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
@echo *
@echo * Create scripts for database CriticalPath executed on Server .\SqlExpress
@echo *
@echo * Please check above lines for errors.
@echo *
@echo * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
@echo .
@pause
