﻿using Haven.Messages;
using Haven.Messaging;
using Haven.Protocols.Hafen.Messages;

namespace Haven.Protocols.Hafen
{
	public abstract class HafenMessageHandlerBase : TypedMessageHandler
	{
		protected HafenMessageHandlerBase()
		{
			InitializeHandlers();
		}

		private void InitializeHandlers()
		{
			AddHandler<UpdateAmbientLight>(Handle);
			AddHandler<UpdateAstronomy>(Handle);
			AddHandler<BuffClearAll>(Handle);
			AddHandler<BuffRemove>(Handle);
			AddHandler<BuffUpdate>(Handle);
			AddHandler<UpdateCharAttributes>(Handle);
			AddHandler<UpdateActions>(Handle);
			AddHandler<UpdateGameTime>(Handle);
			AddHandler<UpdateGameObject>(Handle);
			AddHandler<MapInvalidate>(Handle);
			AddHandler<MapInvalidateGrid>(Handle);
			AddHandler<MapInvalidateRegion>(Handle);
			AddHandler<MapUpdateGrid>(Handle);
			AddHandler<PartyUpdateMember>(Handle);
			AddHandler<PartyChangeLeader>(Handle);
			AddHandler<PartyUpdate>(Handle);
			AddHandler<PlayMusic>(Handle);
			AddHandler<PlaySound>(Handle);
			AddHandler<LoadResource>(Handle);
			AddHandler<WidgetCreate>(Handle);
			AddHandler<WidgetDestroy>(Handle);
			AddHandler<WidgetMessage>(Handle);
			AddHandler<ExitMessage>(Handle);
			AddHandler<ExceptionMessage>(Handle);
			AddHandler<SkyClear>(Handle);
			AddHandler<SkyUpdate>(Handle);
			AddHandler<UpdateLighting>(Handle);
			AddHandler<UpdateWeather>(Handle);
		}

		protected virtual void Handle(WidgetCreate message)
		{
		}

		protected virtual void Handle(WidgetMessage message)
		{
		}

		protected virtual void Handle(WidgetDestroy message)
		{
		}

		protected virtual void Handle(LoadResource message)
		{
		}

		protected virtual void Handle(MapInvalidate message)
		{
		}

		protected virtual void Handle(MapInvalidateGrid message)
		{
		}

		protected virtual void Handle(MapInvalidateRegion message)
		{
		}

		protected virtual void Handle(UpdateCharAttributes message)
		{
		}

		protected virtual void Handle(UpdateGameTime message)
		{
		}

		protected virtual void Handle(UpdateAmbientLight message)
		{
		}

		protected virtual void Handle(UpdateAstronomy message)
		{
		}

		protected virtual void Handle(UpdateActions message)
		{
		}

		protected virtual void Handle(UpdateGameObject message)
		{
		}

		protected virtual void Handle(MapUpdateGrid message)
		{
		}

		protected virtual void Handle(BuffUpdate message)
		{
		}

		protected virtual void Handle(BuffRemove message)
		{
		}

		protected virtual void Handle(BuffClearAll message)
		{
		}

		protected virtual void Handle(PartyChangeLeader message)
		{
		}

		protected virtual void Handle(PartyUpdate message)
		{
		}

		protected virtual void Handle(PartyUpdateMember message)
		{
		}

		protected virtual void Handle(PlaySound message)
		{
		}

		protected virtual void Handle(PlayMusic message)
		{
		}

		protected virtual void Handle(ExceptionMessage message)
		{
		}

		protected virtual void Handle(ExitMessage message)
		{
		}

		protected virtual void Handle(SkyClear message)
		{
		}

		protected virtual void Handle(SkyUpdate message)
		{
		}

		protected virtual void Handle(UpdateLighting message)
		{
		}

		protected virtual void Handle(UpdateWeather message)
		{
		}
	}
}
