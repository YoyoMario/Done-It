(() => {
    const gridSelector = ".daily-log-groups";
    const itemSelector = ":scope > .log-group";

    function createMasonry(grid) {
        let animationFrame = 0;
        const observedItems = new Set();

        const itemResizeObserver = new ResizeObserver(() => scheduleLayout());

        function getItems() {
            return Array.from(grid.querySelectorAll(itemSelector));
        }

        function observeNewItems(items) {
            for (const item of items) {
                if (observedItems.has(item)) {
                    continue;
                }

                observedItems.add(item);
                itemResizeObserver.observe(item);
            }

            for (const item of observedItems) {
                if (!items.includes(item)) {
                    observedItems.delete(item);
                    itemResizeObserver.unobserve(item);
                }
            }
        }

        function layout() {
            animationFrame = 0;

            const items = getItems();
            observeNewItems(items);

            const styles = getComputedStyle(grid);
            const rowGap = Number.parseFloat(
                styles.getPropertyValue("--daily-log-row-gap")
            ) || 24;

            for (const item of items) {
                item.style.gridRowEnd = "auto";
            }

            for (const item of items) {
                const itemHeight = item.getBoundingClientRect().height;
                const rowSpan = Math.ceil(itemHeight + rowGap);

                item.style.gridRowEnd = `span ${rowSpan}`;
            }
        }

        function scheduleLayout() {
            if (animationFrame) {
                cancelAnimationFrame(animationFrame);
            }

            animationFrame = requestAnimationFrame(layout);
        }

        const mutationObserver = new MutationObserver(() => scheduleLayout());
        mutationObserver.observe(grid, {
            childList: true,
            characterData: true,
            subtree: true
        });

        window.addEventListener("resize", scheduleLayout, { passive: true });

        grid.classList.add("is-masonry");
        scheduleLayout();
    }

    function initialize() {
        document.querySelectorAll(gridSelector).forEach(createMasonry);
    }

    if (document.readyState === "loading") {
        document.addEventListener("DOMContentLoaded", initialize, { once: true });
    } else {
        initialize();
    }
})();
