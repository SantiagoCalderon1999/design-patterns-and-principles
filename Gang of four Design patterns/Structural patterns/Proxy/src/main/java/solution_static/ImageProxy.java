package solution_static;

import javafx.geometry.Point2D;

//Proxy class.
public class ImageProxy implements Image {

	private final String name;

	// Reference to the real object
	private BitmapImage image;
	
	private Point2D location;

	public ImageProxy(String name) {
		this.name = name;
	}
	
	@Override
	public void setLocation(Point2D point2d) {
		// If we have a real object, we assign this value to that object
		if(image != null) {
			image.setLocation(point2d);
		} else {
			// Otherwise, we store it in the current object
			location = point2d;
		}
	}

	@Override
	public Point2D getLocation() {
		if(image != null) {
			return image.getLocation();
		}
		return location;
	}

	@Override
	public void render() {
		if(image == null) {
			image = new BitmapImage(name);
			if(location != null) {
				image.setLocation(location);
			}
		}
		image.render();
		
	}
		
}
