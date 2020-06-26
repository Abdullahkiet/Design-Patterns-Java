public class RentVideo {
    
    private Double amount;

    public void setAmount(Double amount) {
        this.amount = 50.50;
    }

    public Double getAmount() {
        return amount;
    }

    public void getAllVideos() {
        VideoStore videoStore = new VideoStore();
        System.out.print(videoStore.getVideo());
    }
}
