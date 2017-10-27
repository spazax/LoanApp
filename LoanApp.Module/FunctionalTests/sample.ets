;#DropDB LoanAppEasyTest

#Application LoanApp.Win
#Application LoanApp.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef LoanApp.Win

*Action About...
 
*Action OK

#EndIf

#IfDef LoanApp.Web
*Action Navigation(My Details)
#EndIf
