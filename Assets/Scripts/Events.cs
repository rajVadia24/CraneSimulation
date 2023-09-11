public static class Events 
{
	public delegate void OnMovement(float xDirection,float yDirection);
	public static OnMovement onPlayerMoves;

	public delegate void ObjectInteract();
	public static ObjectInteract onObjectInteract;
}
