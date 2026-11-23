export const useViewport = () => {
  const viewport = ref("unset");

  onMounted(() => {
    const screenWidth = window.visualViewport?.width;
    if (!screenWidth) return "mobile";

    if (screenWidth > 1200) {
      viewport.value = "desktop";
    } else if (screenWidth > 460) {
      viewport.value = "tablet";
    } else viewport.value = "mobile";
  });

  return viewport;
};
