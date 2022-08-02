using Microsoft.Playwright;

namespace nunit_leak
{
    public class Tests
    {
        public IBrowser Browser { get; set; }
        public IBrowserContext ContextA { get; set; }
        public IBrowserContext ContextB { get; set; }
        public IPage PageA { get; set; }
        public IPage PageB { get; set; }

        [SetUp]
        public async Task Setup()
        {

            IPlaywright playwright = await Playwright.CreateAsync();

            Browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            ContextA = await Browser.NewContextAsync();
            ContextB = await Browser.NewContextAsync();
            PageA = await ContextA.NewPageAsync();
            PageB = await ContextB.NewPageAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await PageA.CloseAsync();
            await PageB.CloseAsync();
            await ContextA.CloseAsync();
            await ContextB.CloseAsync();
            await Browser.CloseAsync();
        }

        [Test]
        public async Task Test1()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test2()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test3()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test4()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test5()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test6()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test7()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test8()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test9()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test10()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test11()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test12()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test13()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test14()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test15()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test16()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test17()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test18()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test19()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }

        [Test]
        public async Task Test20()
        {
            await PageA.SetViewportSizeAsync(1920, 1080);
            await PageA.GotoAsync("https://playwright.dev/");

            await PageB.SetViewportSizeAsync(1920, 1080);
            await PageB.GotoAsync("https://playwright.dev/");

            await Task.Delay(2000);
        }
    }
}