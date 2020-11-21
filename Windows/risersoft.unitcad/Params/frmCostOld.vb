    sum = myView.mainGrid.myDS.Tables(0).Compute("sum(price)", "")

    dt1 = New DataTable
    dt1.Columns.Add("xchng", GetType(String))
    dt1.Columns.Add("Total$", GetType(Decimal))
    dt1.Columns.Add("TotalRs", GetType(Decimal))
    dt1.Columns.Add("Descrip", GetType(String))

    r = dt1.NewRow
    r("xchng") = "1$ = Rs. " & CInt(xchng)
    r("Descrip") = "Total"
    r("TotalRs") = sum
    r("Total$") = sum / xchng
    dt1.Rows.Add(r)

    r = dt1.NewRow
    r("Descrip") = "75% Factor"
    r("TotalRs") = sum / 0.75
    r("Total$") = sum / 0.75 / xchng
    dt1.Rows.Add(r)

    r = dt1.NewRow
    r("Descrip") = "70% Factor"
    r("TotalRs") = sum / 0.7
    r("Total$") = sum / 0.7 / xchng
    dt1.Rows.Add(r)

    r = dt1.NewRow
    r("Descrip") = "80% Factor"
    r("TotalRs") = sum / 0.8
    r("Total$") = sum / 0.8 / xchng
    dt1.Rows.Add(r)

    r = dt1.NewRow
    r("Descrip") = "65% Factor"
    r("TotalRs") = sum / 0.65
    r("Total$") = sum / 0.65 / xchng
    dt1.Rows.Add(r)

    myView.totGrid.BindView(, myUtils.MakeDSfromTable(dt1, False))
    myView.totGrid.myCMain("TOTALSXML") = "<TOTAL><FIELD KEY=""xchng"" BELOW=""Unitname"" ALIGN=""CENTER""/><FIELD KEY=""Total$"" BELOW=""PurchasePrice"" ALIGN=""Right"" FORMAT=""$ #.#""/><FIELD KEY=""TotalRs"" BELOW=""Price"" ALIGN=""Right"" FORMAT=""Rs. #.#""/><FIELD KEY=""Descrip"" BELOW=""CostItemname"" ALIGN=""left""/></TOTAL>"
    myView.totGrid.AlterDS(myView.mainGrid, myView.mainGrid.myCMain)
myView.totGrid.Genwidth(True)




