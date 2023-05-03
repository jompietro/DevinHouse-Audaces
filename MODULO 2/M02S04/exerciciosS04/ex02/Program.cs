using ContaBancariaSpace;

ContaBancaria conta1 = new ContaBancaria("1245");

conta1.getSaldo();

conta1.Deposita(100);

conta1.Saca(30);

Console.WriteLine(conta1.getSaldo());