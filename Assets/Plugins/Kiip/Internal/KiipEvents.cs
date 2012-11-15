using UnityEngine;
using System.Collections;
using System;



public partial class Kiip : MonoBehaviour
{
	// class used to hold the details of a reward from the onContent callback
	public class Content
	{
		public string momentId;
		public int quantity;
		public string transactionId;
		public string signature;
		
		
		public static Content fromCommaDelimitedString( string commaString )
		{
			var c = new Content();
			
			var parts = commaString.Split( new string[] { "," }, StringSplitOptions.None );
			if( parts.Length == 4 )
			{
				c.momentId = parts[0];
				c.quantity = int.Parse( parts[1] );
				c.transactionId = parts[2];
				c.signature = parts[3];
			}
			
			return c;
		}
		
		
		public override string ToString()
		{
			return string.Format( "[Content] momentId: {0}, quantity: {1}, transactionId: {2}, signature: {3}", momentId, quantity, transactionId, signature );
		}
		
	}
	
	
	// Fired when the session fails to start
	public static event Action<string> sessionFailedToStartEvent;

	// Fired when a session starts
	public static event Action sessionStartedEvent;

	// Fired when a moment fails to save
	public static event Action<string> onSaveMomentFailedEvent;

	// Fired when a moment is successfully saved
	public static event Action onSaveMomentFinishedEvent;

	// Fired when a Content object is received
	public static event Action<Content> onContentEvent;

	// Fired when a swarm event occurs
	public static event Action<string> onSwarmEvent;

	// Fired when a notification is shown
	public static event Action onShowNotificationEvent;

	// Fired when a notification is clicked
	public static event Action onClickNotificationEvent;

	// Fired when a notification is dismissed
	public static event Action onDismissNotificationEvent;

	// Fired when a modal is shown
	public static event Action onShowModalEvent;

	// Fired when a modal is dismissed
	public static event Action onDismissModalEvent;
	
	// Fired when a poptart is shown
	public static event Action onShowPoptartEvent;
	
	// Fired when a poptart is dismissed
	public static event Action onDismissPoptartEvent;
	
	
	
	public void sessionFailedToStart( string param )
	{
		if( sessionFailedToStartEvent != null )
			sessionFailedToStartEvent( param );
	}


	public void sessionStarted( string empty )
	{
		if( sessionStartedEvent != null )
			sessionStartedEvent();
	}


	public void onSaveMomentFailed( string param )
	{
		if( onSaveMomentFailedEvent != null )
			onSaveMomentFailedEvent( param );
	}


	public void onSaveMomentFinished( string empty )
	{
		if( onSaveMomentFinishedEvent != null )
			onSaveMomentFinishedEvent();
	}


	public void onContent( string commaDelimitedString )
	{
		if( onContentEvent != null )
			onContentEvent( Content.fromCommaDelimitedString( commaDelimitedString ) );
	}


	public void onSwarm( string id )
	{
		if( onSwarmEvent != null )
			onSwarmEvent( id );
	}


	public void onShowNotification( string empty )
	{
		if( onShowNotificationEvent != null )
			onShowNotificationEvent();
	}


	public void onClickNotification( string empty )
	{
		if( onClickNotificationEvent != null )
			onClickNotificationEvent();
	}


	public void onDismissNotification( string empty )
	{
		if( onDismissNotificationEvent != null )
			onDismissNotificationEvent();
	}


	public void onShowModal( string empty )
	{
		if( onShowModalEvent != null )
			onShowModalEvent();
	}


	public void onDismissModal( string empty )
	{
		if( onDismissModalEvent != null )
			onDismissModalEvent();
	}
	
	
	public void onShowPoptart( string empty )
	{
		if( onShowPoptartEvent != null )
			onShowPoptartEvent();
	}
	
	
	public void onDismissPoptart( string empty )
	{
		if( onDismissPoptartEvent != null )
			onDismissPoptartEvent();
	}

}
