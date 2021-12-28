import { Line, Subcommand } from "https://deno.land/x/line@v0.1.1/mod.ts";

class Hello extends Subcommand {
  public signature = "hello [string]";
  public description = "Say hello [string].";

  public handle(): void { 
    const name = this.getArgumentValue("string");
    if (!name) return console.error("Name not specified.");
    console.log(`Hello ${name}`);
  }
}


const cli = new Line({
  command: "test",
  name: "Test CLI",
  description: "A test CLI.",
  version: "v1.0.0",
  subcommands: [
    Hello,
  ],
});

cli.run();
