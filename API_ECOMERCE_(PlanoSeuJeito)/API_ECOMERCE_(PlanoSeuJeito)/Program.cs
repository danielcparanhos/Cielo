
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OpenQA.Selenium.Support.UI;
using System.Timers;
using System.IO;
using System.Collections;
using System.Drawing.Imaging;
using System.Threading;
using System.Text.RegularExpressions;





namespace API_E_Comerce_PlanoSeuJeito
{
    class Program
    {
        static void Main(string[] args)
        {
            // ALTERAR EM CADA MÁQUINA: LINHAS : 56 57 180
            // Adicionar no diretório de pasta: chromedriver.exe , geckodriver.exe , nuget.exe

            ChromeOptions optionsdriver = new ChromeOptions();                                            // Define o Chrome para                                                  
            optionsdriver.AddArgument("--incognito");                                                     // ser inicializado em modo anônimo.
            IWebDriver driver = new ChromeDriver(optionsdriver);                                          // Instancia uma janela do Chrome em modo anônimo.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            driver.Url = "https://www.cielo.com.br/aceite-cartao/";                                       // Abre a URL na página de Máquinas.
            WebDriverWait wait53 = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            driver.Manage().Window.Maximize();                                                            // Maximiza Janela.
            IWebDriver aux = new ChromeDriver();                                                          // Instância uma janela do Chrome em modo normal.
            aux.Manage().Window.Minimize();
            WebDriverWait wait54 = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

            // ------------------------ DETALHES DO PEDIDO: PASSO 1 ----------------------------- >

            // ________________________ 1.1 Informações de contato _______________________________________________________________________________________________________________________________________________________________________________

            aux.Url = "https://www.4devs.com.br/gerador_de_pessoas";                                                                                     // Abre o site 4Devs na aba "Pessoas".            
            WebDriverWait wait55 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.SwitchTo().Window(driver.WindowHandles.Last());                                                                                       // Volta para site da Cielo.                                                                                                           // Minimiza Janela Geração de Pessoas
            aux.FindElement(By.XPath(".//*[@id='bt_gerar_pessoa']")).Click();                                                                            // Gera dados de "Pessoas".
            WebDriverWait wait73 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            aux.FindElement(By.XPath(".//*[@id='cpf']/span[2]")).Click();                                                                                // Copia dados de "CPF".
            WebDriverWait wait72 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            aux.FindElement(By.XPath(".//*[@id='cpf']/span[2]")).Click();                                                                                // Copia dados de "CPF".
            WebDriverWait wait71 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            aux.FindElement(By.XPath(".//*[@id='cpf']/span[2]")).Click();                                                                                // Copia dados de "CPF"   4X
            WebDriverWait wait70 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            aux.FindElement(By.XPath(".//*[@id='cpf']/span[2]")).Click();                                                                                // Copia dados de "CPF".
            WebDriverWait wait69 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            aux.Close();                                                                                                                                 // Fecha o site 4Devs de "Geração de Pessoa".
            WebDriverWait wait68 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath(".//*[@id='nainternet']/section/article[4]/div/span[2]/a[1]")).Click();                                          // Seleciona a máquina     (Current: "API E-Commerce").
            driver.FindElement(By.XPath(".//*[@id='plans_conventional_section']/div[1]/div[1]/div[1]/label/span")).Click();                              // Seleciona o plano       (Current: "Cielo Plano Seu Jeito").            
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[1]/div/button[2]")).Click();                                    // Seleciona opção cliente (Current: "Não).     
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[2]/div/input[3]")).Click();                                     // Seleciona tipo cliente  (Current: "Física").
            WebDriverWait wait67 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[2]/div/input[3]")).Click();                                     // Seleciona campo CPF.
            WebDriverWait wait66 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[2]/div/input[3]")).SendKeys(Keys.Control + "v");                // Preenche o campo CPF.
            WebDriverWait wait65 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[3]/div/input")).SendKeys("Teste Wunderman");                    // Preenche o campo Nome.          
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[4]/div/input")).SendKeys("8528139502");                         // Preenche o campo Telefone.                                                  
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[5]/div[1]/div/input")).Clear();                                 // Limpa campo Email.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[5]/div[2]/div/input")).Clear();                                 // Limpa campo Confirmação de Email.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[5]/div[1]/div/input")).SendKeys("testewunderman@hotmail.com");  // Preenhce o Campo Email.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[3]/div[2]/div[5]/div[2]/div/input")).SendKeys("testewunderman@hotmail.com");  // Preenche o Campo Confirmação de Email.
            WebDriverWait wait13 = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

            // _______________________  1.2 Informações sobre o negócio ________________________________________________________________________________________________________________________________________________________________________

            driver.FindElement(By.XPath(".//*[@id='field-business-type']/div/div/div/div[1]")).Click();                                                  // Clica no campo Ramo.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath(".//*[@id='field-business-type']/div/div/div/div[2]/div/div[7]")).Click();                                       // Seleciona Campo.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/div/button")).Click();                                                                // Avança para a próxima página.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            // ------------------------ iNFORMAÇÕES: PASSO 2 ----------------------------- >

            // __________________________2.1 Dados Bancários ___________________________________________________________________________________________________________________________________________________________________________________

            driver.FindElement(By.XPath(".//*[@id='banking_section']/div[2]/div/div[3]/div/div/div[1]")).Click();                                       // Seleciona Campo Banco.     
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.XPath(".//*[@id='banking_section']/div[2]/div/div[3]/div/div/div[2]/div/div[1]")).Click();                            // Seleciona Banco ( Current: 001 - Banco do Brasil S.A).
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.FindElement(By.XPath(".//*[@id='bank-type']/div/div[1]/label/span")).Click();                                                        // Seleciona Tipo de Conta ( Current: Conta Corrente).
            WebDriverWait wait36 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            IWebDriver Conta = new ChromeDriver();                                                                                                      // Instancia uma nova janela do Chrome.
            Conta.Manage().Window.Minimize();
            Conta.Url = "https://www.4devs.com.br/gerador_conta_bancaria";                                                                              // Abre Site 4Devs : Geração de conta.                  
            WebDriverWait wait40 = new WebDriverWait(driver, TimeSpan.FromSeconds(110));
            Conta.FindElement(By.XPath(".//*[@id='cc_banco']")).Click();                                                                                // Seleciona o ComboBox Banco. 
            WebDriverWait wait41 = new WebDriverWait(driver, TimeSpan.FromSeconds(110));
            Conta.FindElement(By.XPath(".//*[@id='cc_banco']/option[2]")).Click();                                                                      // Seleciona opção banco (Current: Banco do Brasil).
            WebDriverWait wait74 = new WebDriverWait(driver, TimeSpan.FromSeconds(110));
            driver.FindElement(By.XPath(".//*[@id='banking_section']/div[2]/div/div[1]/div/button[1]")).Click();                                        // Possuir conta corrente ( Current: "Sim").                    
            WebDriverWait wait31 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            Conta.FindElement(By.XPath(".//*[@id='btn_gerar_conta']")).Click();                                                                         // Clica em "Gerar Conta".
            Conta.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            string aux_banco = Conta.FindElement(By.XPath(".//*[@id='conta_corrente']")).Text;                                                          // Cria uma variável com o valor do campo "Conta" em string.
            string banco = aux_banco.Substring(0, 7);                                                                                                   // Cria uma variável com o valor dos 07 primeiros digitos do campo "Conta" em string.
            Conta.FindElement(By.XPath(".//*[@id='conta_corrente']/span")).Click();                                                                     // Copia dados de Conta.
            WebDriverWait wait42 = new WebDriverWait(driver, TimeSpan.FromSeconds(110));
            driver.SwitchTo().Window(driver.WindowHandles.Last());                                                                                      // Volta pro Sita da Cielo.
            WebDriverWait wait43 = new WebDriverWait(driver, TimeSpan.FromSeconds(110));
            driver.FindElement(By.XPath(".//*[@id='ipt-account-number']/div/input")).Clear();                                                           // Limpa o campo Banco.
            driver.FindElement(By.XPath(".//*[@id='bank-account']/div[4]/div/input")).Clear();                                                          // Limpa o campo Dígito.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            driver.FindElement(By.XPath(".//*[@id='ipt-account-number']/div/input")).SendKeys(banco);                                                    // Preenche Campo Conta.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            string aux_digito = Conta.FindElement(By.XPath(".//*[@id='conta_corrente']")).Text;                                                          // Cria uma variável com o valor do campo "Conta" em string.
            char digito = aux_digito[aux_digito.Length - 1];                                                                                             // Cria uma variável com o valor do ultimo dígito do campo "Conta" em char.
            aux_digito = Convert.ToString(digito);                                                                                                       // Cria uma váriável com o valor do ultimo dígito do campo "Conta" em string.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            driver.FindElement(By.XPath(".//*[@id='bank-account']/div[4]/div/input")).SendKeys(aux_digito);                                              // Preenche o campo dígito.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            Conta.FindElement(By.XPath(".//*[@id='agencia']/span")).Click();                                                                             // Copia dados de Agência.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            driver.FindElement(By.XPath(".//*[@id='bank-account']/div[1]/div[1]/input")).SendKeys(Keys.Control + "v");                                   // Preenche o campo Agência.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);

            // _________________________ 2.2 Informações Adicionais _________________________________________________________________________________________________________________________________________________________________________

            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[2]/div[2]/div[2]/div[2]/div/input")).SendKeys("19947394792");                 // Preenche o campo Outro Telefone.
            WebDriverWait wait20 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[2]/div[2]/div[2]/div[1]/div/div[1]/div/div/div[1]")).Click();                 // Seleciona Campo Dia.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[2]/div[2]/div[2]/div[1]/div/div[1]/div/div/div[2]/div/div[2]")).Click();      // Seleciona Dia ( Current: 02).
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[2]/div[2]/div[2]/div[1]/div/div[2]/div/div/div[1]")).Click();                 // Seleciona Campo Mês.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[2]/div[2]/div[2]/div[1]/div/div[2]/div/div/div[2]/div/div[1]")).Click();      // Seleciona Mês ( Current: 01).
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[2]/div[2]/div[2]/div[1]/div/div[3]/div/div/div[1]")).Click();                 // Seleciona Campo Ano.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath(".//*[@id='main']/form/div/section[2]/div[2]/div[2]/div[1]/div/div[3]/div/div/div[2]/div/div[19]")).Click();     // Seleciona Ano ( Current: 2000).
            WebDriverWait wait29 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // ___________________________________ 2.2 Endereço ____________________________________________________________________________________________________________________________________________________________________________


            driver.FindElement(By.XPath(".//*[@id='address_main_section']/div[3]/div[1]/div/input")).Clear();                                            // Limpa Campo CEP.
            WebDriverWait wait32 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.FindElement(By.XPath(".//*[@id='address_main_section']/div[3]/div[1]/div/input")).SendKeys("59152693");                               // Preenche Campo CEP.
            WebDriverWait wait60 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.FindElement(By.XPath(".//*[@id='address_main_section']/div[3]/div[2]/div[2]/div/input")).SendKeys("50");                              // Inserir Número Residência.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            do
            {
                driver.FindElement(By.XPath(".//*[@id='main']/form/div/div/button[1]")).Click();
            }

            while (driver.FindElement(By.XPath(".//*[@id='status-modal']/div[2]/div[1]")).Displayed == false);

            //------------------------ EVIDÊNCIA ------------------------------------- >

            //______________________________________________________________________________________________________________________________________________________________________________________________________________________________________

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(7000); 
            Conta.Close();                                                                                                                                                 // Fecha a Janela no 4Devs de "Conta"
            void Take_ScreenShotRemoteBrowser()                                                                                                                            // Cria um método para registrar evidência
            {
                var ss = ((ITakesScreenshot)driver).GetScreenshot();
                string date = Convert.ToString(DateTime.Now);                                                                                                                       // Converte o DateTime.Now em uma string
                string input = date;                                                                                                                                                // Cria variável que assume valor de "date"
                string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";                                                                                                              // Remove os caracteres especiais de "date"
                string replacement = "-";                                                                                                                                           // Substitui os caracteres especiais de "date" por "-"
                Regex rgx = new Regex(pattern);                                                                                                                                     // Remove os caracteres especiais de "date"
                string result = "API_ECOMMERCE_PSJ_" + rgx.Replace(input, replacement) + ".png";                                                                                    // Váriavel que recebe nome da máquina, mais valor de DateTime.
                string save_path = ("C:\\Users\\mathe\\Desktop\\Cielo\\API e-Commerce Cielo\\API_ECOMERCE_(PlanoSeuJeito)\\API_ECOMERCE_(PlanoSeuJeito)\\Evidencias\\" + result);   // Cria uma string que recebe o camninho de salvamento como valor, mais o valor de "result"
                ss.SaveAsFile(save_path, ScreenshotImageFormat.Png);                                                                                                                // Salva a Screenshot
            }
            Thread.Sleep(10000);
            Take_ScreenShotRemoteBrowser();                                                                                                                                // Executa o médoto de Screenshot
            driver.Quit();                                                                                                                                                 // Fecha o site da cielo            
            
        }
    }
}