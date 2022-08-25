using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace popopixel
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D texture2D;

        public Game()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            texture2D = new Texture2D(GraphicsDevice, 128, 128);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            texture2D = new Texture2D(GraphicsDevice, 128, 128);
            Color[] data = new Color[128 * 128];
            for (int pixel = 0; pixel < data.Length; pixel++)
            {
                data[pixel] = Color.Black;
            }
            texture2D.SetData(data);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.AliceBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(texture2D, new Vector2(0, 0), Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}