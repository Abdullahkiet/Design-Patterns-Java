public class VideoStore {

    private Video video[];

    //Get All videos from db
    public void setVideo() {
        DbOperation db = new DbOperation();
        video = db.getVideos();
    }
    
    //Return videos
    public Video[] getVideo() {
        return video;
    }
}
