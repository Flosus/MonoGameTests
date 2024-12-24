namespace Baldrian

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

module Game =
    type BaldrianGame() as this =
        inherit Game()

        let graphics = new GraphicsDeviceManager(this)
        let mutable spriteBatch: SpriteBatch = null

        do
            this.Content.RootDirectory <- "Content"
            this.IsMouseVisible <- true

        override this.Initialize() =

            base.Initialize()

        override this.LoadContent() =
            spriteBatch <- new SpriteBatch(this.GraphicsDevice)
            base.LoadContent()

        override this.Update(gameTime) =
            
            base.Update(gameTime)

        override this.Draw(gameTime) =
            this.GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime)
    
    [<EntryPoint>]
    let main args =
        let game = new BaldrianGame()
        game.Run ()
        0
